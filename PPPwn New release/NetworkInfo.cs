using PPPwn_New_release.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPwn_New_release
{
    public enum NetConnectionStatus
    {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2,
        Disconnecting = 3,
        HardwareNotPresent = 4,
        HardwareDisabled = 5,
        HardwareMalfunction = 6,
        MediaDisconnected = 7,
        Authenticating = 8,
        AuthenticationSucceeded = 9,
        AuthenticationFailed = 10,
        InvalidAddress = 11,
        CredentialsRequired = 12
    }

    public class NetworkInfo
    {
        string m_DeviceName;
        public string DeviceName
        {
            get { return m_DeviceName; }
            set { m_DeviceName = value; }
        }
        string m_MacAddress;
        public string MacAddress
        {
            get { return m_MacAddress; }
            set { m_MacAddress = value; }
        }
        string m_AdapterType;
        public string AdapterType
        {
            get { return m_AdapterType; }
            set { m_AdapterType = value; }
        }
        string m_IP;
        public string IP
        {
            get { return m_IP; }
            set { m_IP = value; }
        }
        string m_Mask;
        public string Mask
        {
            get { return m_Mask; }
            set { m_Mask = value; }
        }
        string m_DefaultGateway;
        public string DefaultGateway
        {
            get { return m_DefaultGateway; }
            set { m_DefaultGateway = value; }
        }
        string m_ConnectionID;
        public string ConnectionID
        {
            get { return m_ConnectionID; }
            set { m_ConnectionID = value; }
        }
        NetConnectionStatus m_status;
        public NetConnectionStatus Status
        {
            get { return m_status; }
            set { m_status = value; }
        }

        public string GetHelp()
        {
            string t_msg = "Normal Connection.";
            if (m_status == NetConnectionStatus.Connected)
            {
                t_msg = "Connect succeed.";
            }
            else if (m_status == NetConnectionStatus.Disconnected)
            {
                t_msg = "Your connection was disable, \nplease check Network Setting in Console.";


            }
            else if (m_status == NetConnectionStatus.MediaDisconnected)
            {
                t_msg = "Cable had bad contact with Network \nPlease check it.";

            }

            return t_msg;
        }
    }
}
