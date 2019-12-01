using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToArduino
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Dashboard()
        {
            InitializeComponent();

            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBoxPort.SelectedItem = ports[0];
                }
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void enableControls()
        {
            Controlgroup.Enabled = true;
            Lcdgroup.Enabled = true;


        }

        private void disableControls()
        {
            Controlgroup.Enabled = false;
            Lcdgroup.Enabled = false;
            
        }

        private void resetDefaults()
        {
            checkBoxLed0.Checked = false;
            checkBoxLed1.Checked = false;
            messageTXT.Text = "";

        }

        private void connectBTN_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.Items.Count < 1)
            {
                MessageBox.Show("Please choose port");
            }
            else
            {
                if (!isConnected)
                {
                    connectToArduino();
                }
                else
                {
                    disconnectFromArduino();
                }
            }
        }
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            connectBTN.Text = "Disconnect";
            enableControls();
        }
        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            connectBTN.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void checkBoxLed0_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed0.Checked)
                {
                    port.Write("#LED0ON\n");
                }
                else
                {
                    port.Write("#LED0OF\n");
                }
            }
        }

        private void checkBoxLed1_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed1.Checked)
                {
                    port.Write("#LED1ON\n");
                }
                else
                {
                    port.Write("#LED1OF\n");
                }
            }
        }

        private void checkBoxLed2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed2.Checked)
                {
                    port.Write("#LED2ON\n");
                }
                else
                {
                    port.Write("#LED2OF\n");
                }
            }
        }

        private void checkBoxLed3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBoxLed3.Checked)
                {
                    port.Write("#LED3ON\n");
                }
                else
                {
                    port.Write("#LED3OF\n");
                }
            }
        }

        private void sendMessageBTN_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + messageTXT.Text + "#\n");
            }
        }
    }
}
