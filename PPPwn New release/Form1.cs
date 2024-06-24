using PPPwn_New_release.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPwn_New_release
{
    public partial class Form1 : Form
    {

        Thread _thread;
        bool m_IsAlive;
        MethodInvoker UIInvoke;
        int m_Index;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            m_Index = -1;
            NetworkManager.Instance.StartMonitor();
            m_IsAlive = true;
            UIInvoke = new MethodInvoker(UpdateUI);
            Initial();
            _thread = new Thread(new ThreadStart(UpdateStatus));
            _thread.Start();


        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (darkComboBox2.Text == "" | string.IsNullOrEmpty(darkComboBox2.Text))
            {
                MessageBox.Show("interface");

            }
            else
            {
                if (darkComboBox1.Text == "" | string.IsNullOrEmpty(darkComboBox1.Text))
                {
                    MessageBox.Show("PPPwn PS4 FW");

                }
                else
                {
                    if (darkComboBox4.Text == "" | string.IsNullOrEmpty(darkComboBox4.Text))
                    {
                        darkSectionPanel2.Location = new System.Drawing.Point(13, 127);
                        darkSectionPanel2.Visible = true;

                    }
                    else
                    {
                        //PS4-GoldHen-All-FW-900-960-1001-1100
                        if (darkComboBox4.Text == "GoldHen")
                        {
                            //900
                            if (darkComboBox1.Text == "900")
                            {

                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x30, 0x30, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x30, 0x30, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                            //903
                            if (darkComboBox1.Text == "903")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x30, 0x33, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();
                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x30, 0x33, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();
                            }
                            //960
                            if (darkComboBox1.Text == "960")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x36, 0x30, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();
                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x36, 0x30, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                            //1001
                            if (darkComboBox1.Text == "1001")
                            {

                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x30, 0x30, 0x31, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();
                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x30, 0x30, 0x31, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();


                            }
                            //1050
                            if (darkComboBox1.Text == "1050")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x30, 0x35, 0x30, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();
                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x30, 0x35, 0x30, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                            //1100
                            if (darkComboBox1.Text == "1100")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x31, 0x30, 0x30, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();
                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x31, 0x30, 0x30, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x32, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                        }
                        //PS4Hen-All-FW-900-903-960-1001-150-1100
                        if (darkComboBox4.Text == "Hen")
                        {
                            //900
                            if (darkComboBox1.Text == "900")
                            {

                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x30, 0x30, };

                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x30, 0x30, };

                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };

                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();
                            }
                            //903
                            if (darkComboBox1.Text == "903")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x30, 0x33, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x30, 0x33, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();
                            }
                            //960
                            if (darkComboBox1.Text == "960")
                            {

                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x30, 0x39, 0x36, 0x30, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x30, 0x39, 0x36, 0x30, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();


                            }
                            //1001
                            if (darkComboBox1.Text == "1001")
                            {

                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x30, 0x30, 0x31, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x30, 0x30, 0x31, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();


                            }
                            //1050
                            if (darkComboBox1.Text == "1150")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x31, 0x35, 0x30, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x31, 0x35, 0x30, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                            //1100
                            if (darkComboBox1.Text == "1100")
                            {
                                BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer = new byte[] { 0x31, 0x31, 0x30, 0x30, };
                                binaryWriter.BaseStream.Position = 0x6C63; ;
                                binaryWriter.Write(buffer);
                                binaryWriter.Close();

                                BinaryWriter binaryWriter01 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer01 = new byte[] { 0x31, 0x31, 0x30, 0x30, };
                                binaryWriter01.BaseStream.Position = 0x6CAC; ;
                                binaryWriter01.Write(buffer01);
                                binaryWriter01.Close();

                                BinaryWriter binaryWriter02 = new BinaryWriter(new FileStream(@"pppwn.py", FileMode.Open));
                                byte[] buffer02 = new byte[] { 0x48, };
                                binaryWriter02.BaseStream.Position = 0x6CBD; ;
                                binaryWriter02.Write(buffer02);
                                binaryWriter02.Close();

                            }
                        }
                        //python pppwn.py
                        try
                        {
                            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "PPPwn.bat");
                            sw.WriteLine("python pppwn.py --interface=" + darkLabel1.Text + darkComboBox2.Text + darkLabel1.Text + " --fw=" + darkComboBox1.Text + "\npause");
                            sw.Close();
                            System.Diagnostics.Process.Start(@"PPPwn.bat");
                        }
                        catch
                        {

                        }

                    }
                }


            }
        }
        void Initial()
        {
            foreach (NetworkInfo info in NetworkManager.Instance.Informations.Values)
            {
                darkComboBox2.Items.Add(info.ConnectionID);
            }
        }
        void UpdateStatus()
        {
            while (m_IsAlive)
            {
                try
                {
                    Invoke(UIInvoke);
                }
                catch { }
                Thread.Sleep(300);

            }
        }
        void UpdateUI()
        {
            if (m_Index >= 0)
            {
                string key = darkComboBox2.Items[darkComboBox2.SelectedIndex].ToString();
                SetInfornation(NetworkManager.Instance.Informations[key]);

               
            }
            else
            {
                ClearInformation();
               

            }
        }

        void SetInfornation(NetworkInfo info)
        {
            lblHelp.Text = info.GetHelp();
        }

        void ClearInformation()
        {
            lblHelp.Text = "";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetworkManager.Instance.Destory();
            m_IsAlive = false;


        }

        private void darkComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(darkComboBox2.SelectedIndex);
            m_Index = darkComboBox2.SelectedIndex;

        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            Process.Start(@"Rundll32.exe", " shell32.dll,Control_RunDLL ncpa.cpl");
        }

        private void lblHelp_ClientSizeChanged(object sender, EventArgs e)
        {
            if (lblHelp.Text == "Your connection was disable, \nplease check Network Setting in Console.")
            {
                pictureBox1.Image = Resources.disable00;
            }
            if (lblHelp.Text == "Connect succeed.")
            {
                pictureBox1.Image = Resources.enable0;
            }
            if (lblHelp.Text == "Cable had bad contact with Network \nPlease check it.")
            {
                pictureBox1.Image = Resources.disable0;
            }

        }

        private void darkLabel5_Click(object sender, EventArgs e)
        {
            darkSectionPanel1.Location = new System.Drawing.Point(9, 63);
            darkSectionPanel1.Visible = true;
        }

        private void darkLabel6_Click(object sender, EventArgs e)
        {
            darkSectionPanel1.Visible = false;
        }

        private void darkComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            Process.Start("USB = GoldHen");
        }

        private void darkLabel12_Click(object sender, EventArgs e)
        {
            darkSectionPanel2.Visible = false;
        }

        private void darkButton4_Click(object sender, EventArgs e)
        {
            darkSectionPanel2.Visible = false;
        }
    }
}
