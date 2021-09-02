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

namespace pcksimulatorv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.DataBits = 8;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            portnames.Items.AddRange(SerialPort.GetPortNames());
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Text += serialPort1.ReadExisting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox2.Text);
        }

        private void btnport_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Lportstatus.ForeColor = Color.Red;
                Lportstatus.Text = "Port Kapalı";
            }
            else
            {
                serialPort1.DataBits = Convert.ToInt32(databitss.Text);
                serialPort1.BaudRate = Convert.ToInt32(baudrates.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), paritybitss.GetItemText(paritybitss.SelectedItem));
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbitss.GetItemText(stopbitss.SelectedItem));
                serialPort1.PortName = portnames.Text;
                serialPort1.Open();
                this.Text = serialPort1.PortName;
                Lportstatus.ForeColor = Color.Green;
                Lportstatus.Text = "Port Açık";
            }

        }
    }

}
