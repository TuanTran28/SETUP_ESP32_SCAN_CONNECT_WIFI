/******************************************************************************
===============================================================================
*project: Control esp32 to scan and connect to a wifi.
* Author: Tuan Tran
* Start day:  June 07 2020
===============================================================================
******************************************************************************/
/*
===============================================================================
INCLUDE FILE
===============================================================================
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

/*
===============================================================================
SOURCE FILE
===============================================================================
*/
namespace Setup_Wifi
{
    public partial class Form1 : Form
    {

        String[] Ports = SerialPort.GetPortNames();
        string s_InputData ="0";
        string[] SSID_List = {"0"};

        public Form1()
        {
            InitializeComponent();
            SelectCom.Items.AddRange(Ports);
            // BaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            SelectBaurate.Items.AddRange(BaudRate);
            // DataBits
            string[] Databits = { "6", "7", "8" };
            DataBit.Items.AddRange(Databits);
            // Parity
            string[] Parity = { "None", "Odd", "Even" };
            SelectParity.Items.AddRange(Parity);
            // Stop bit
            string[] stopbit = { "1", "1.5", "2" };
            StopBit.Items.AddRange(stopbit);
        }
        private void Connect_Port_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connect_Port.Text == "Connect")
                {
                    GateCom.PortName = SelectCom.Text;
                    GateCom.BaudRate = Int32.Parse(SelectBaurate.Text);
                    GateCom.DataBits = Int32.Parse(DataBit.Text);
                    GateCom.StopBits = StopBits.One;
                    GateCom.Parity = Parity.None;
                    GateCom.Open();
                    Connect_Port.Text = "Disconnect";

                }
                else
                {
                    GateCom.Close();
                    Connect_Port.Text = "Connect";
                }
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString("you have to choose a comport!"));
            }
          }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectBaurate.SelectedIndex = 7; // 115200
            DataBit.SelectedIndex = 2; // 8
            SelectParity.SelectedIndex = 0; // None
            StopBit.SelectedIndex = 0; // 1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GateCom.IsOpen)
            {
                GateCom.Write("Scan#");
                List_SSID.Items.Clear();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GateCom.IsOpen)
            {
               s_InputData = GateCom.ReadExisting();
            }
            if(s_InputData != "")
            {
                if ((s_InputData[0] == '$'))
                {
                    s_InputData = s_InputData.Remove(0, 1);
                    ErrorText_WifiStatus.Text = s_InputData;
                    if(s_InputData == "Connected")
                    {
                        Error2_Text.Text = "Connected";
                        Error2_Text.BackColor = Color.Green;
                    }
                    else if(s_InputData == "Cant Connected")
                    {
                        Error2_Text.Text = "DisConnected";
                        Error2_Text.BackColor = Color.Red;
                    }
                }
                else
                {
                    SSID_List[0] = s_InputData;
                    List_SSID.Items.AddRange(SSID_List);
                    List_SSID.Update();
                }
            }
            if(Check_SSID.CheckState == CheckState.Checked)
            {
                if (List_SSID.Text != "")
                {
                    SSID_Name.Text = List_SSID.Text.Remove(0, 3);
                    SSID_Name.Text = SSID_Name.Text.Remove(SSID_Name.Text.IndexOf('(')-1);
                }
            }
        }

        private void Connect_Wifi_Click(object sender, EventArgs e)
        {
            if (GateCom.IsOpen)
            {

                GateCom.Write("("+ SSID_Name.Text+ ")");
                GateCom.Write("["+ Password_Text.Text + "]" + "#");
            }
            else
            {
                ErrorText_WifiStatus.Text = "Please choose the COMPORT";
            }
        }
    }
}
