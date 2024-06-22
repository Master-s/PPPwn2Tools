using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Threading;

namespace PPPwn_New_release
{
    public class NetworkManager
    {
        static readonly NetworkManager m_instance = new NetworkManager();
        static Dictionary<string, NetworkInfo> m_Informations = new Dictionary<string, NetworkInfo>();
        Thread _thread;
        bool m_IsAlive;

        public static NetworkManager Instance
        {
            get { return m_instance; }
        }
        public Dictionary<string, NetworkInfo> Informations
        {
            get { return m_Informations; }
        }
        private NetworkManager() { }
        static NetworkManager()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID IS NOT NULL");
            foreach (ManagementObject mo in searcher.Get())
            {
                NetworkInfo info = new NetworkInfo();
                info.DeviceName = ParseProperty(mo["Description"]);
                info.AdapterType = ParseProperty(mo["AdapterType"]);
                info.MacAddress = ParseProperty(mo["MACAddress"]);
                info.ConnectionID = ParseProperty(mo["NetConnectionID"]);
                info.Status = (NetConnectionStatus)Convert.ToInt32(mo["NetConnectionStatus"]);
                SetIP(info);
                m_Informations.Add(info.ConnectionID, info);
            }
        }
        ~NetworkManager()
        {
            m_IsAlive = false;
        }

        static string ParseProperty(object data)
        {
            if (data != null)
                return data.ToString();
            return "";
        }


        public void StartMonitor()
        {
            m_IsAlive = true;
            _thread = new Thread(new ThreadStart(Monitor));
            _thread.Start();
        }

        public void Destory()
        {
            m_IsAlive = false;
            try
            {
                _thread.Abort();
                _thread = null;
            }
            catch { }
        }

        void Monitor()
        {
            while (m_IsAlive)
            {
                try
                {
                    Update();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("[Update]:" + ex.Message);
                }
                Thread.Sleep(100);
            }
        }

        void Update()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID IS NOT NULL");
            foreach (ManagementObject mo in searcher.Get())
            {
                try
                {
                    if (m_Informations.ContainsKey(ParseProperty(mo["NetConnectionID"])))
                    {
                        NetConnectionStatus status = (NetConnectionStatus)Convert.ToInt32(mo["NetConnectionStatus"]);
                        NetworkInfo info = m_Informations[ParseProperty(mo["NetConnectionID"])];
                        info.DeviceName = ParseProperty(mo["Description"]);
                        info.AdapterType = ParseProperty(mo["AdapterType"]);
                        info.MacAddress = ParseProperty(mo["MACAddress"]);
                        info.ConnectionID = ParseProperty(mo["NetConnectionID"]);
                        info.Status = status;
                        if (info.Status != NetConnectionStatus.Connected)
                        {
                            info.IP = "0.0.0.0";
                            info.Mask = "0.0.0.0";
                            info.DefaultGateway = "0.0.0.0";
                        }
                        else
                        {
                            SetIP(info);
                        }
                        //m_Informations[ParseProperty(mo["NetConnectionID"])] = info;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("[Update]:" + ex.Message);
                }
            }
        }
        static void SetIP(NetworkInfo info)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject mo in objMC.GetInstances())
            {
                try
                {
                    if (!(bool)mo["ipEnabled"])
                        continue;
                    if (mo["MACAddress"].ToString().Equals(info.MacAddress))
                    {
                        string[] ip = (string[])mo["IPAddress"];
                        info.IP = ip[0];
                        string[] mask = (string[])mo["IPSubnet"];
                        info.Mask = mask[0];
                        string[] gateway = (string[])mo["DefaultIPGateway"];
                        //info.DefaultGateway = gateway[0];
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("[SetIP]:" + ex.Message);
                }
            }
        }

        public void ConsoleWriteAllStatus()
        {
            foreach (NetworkInfo info in m_Informations.Values)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Device Name:" + info.DeviceName);
                Console.WriteLine("Adapter Type:" + info.AdapterType);
                Console.WriteLine("MAC ID:" + info.MacAddress);
                Console.WriteLine("Connection Name:" + info.ConnectionID);
                Console.WriteLine("IP Address:" + info.IP);
                Console.WriteLine("Connection Status:" + info.Status.ToString());
                Console.WriteLine("=========================================");
            }
        }

        public static void ConsoleWriteStatus(NetworkInfo info)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Device Name:" + info.DeviceName);
            Console.WriteLine("Adapter Type:" + info.AdapterType);
            Console.WriteLine("MAC ID:" + info.MacAddress);
            Console.WriteLine("Connection Name:" + info.ConnectionID);
            Console.WriteLine("IP Address:" + info.IP);
            Console.WriteLine("Connection Status:" + info.Status.ToString());
            Console.WriteLine("=========================================");
        }

    }
}
