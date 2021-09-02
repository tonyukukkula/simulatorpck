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
        Random r = new Random();
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
            tbRX.Text += "\n---" + serialPort1.ReadExisting() + "---";
        }

        private void btnport_Click(object sender, EventArgs e)
        {
            try
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
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(tbsizeofpacket.Text) > 7 && Convert.ToInt16(tbsizeofpacket.Text) < 255)
                {
                    byte[] pck = createPacket(Convert.ToInt16(tbsizeofpacket.Text));
                    tbTX.Text = BitConverter.ToString(pck);
                }
                else
                {
                    MessageBox.Show("Paket büyüklüğü (7-255) arası olmalıdır");
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private byte[] createPacket(short size)
        {
            byte[] arr = new byte[size];
            //arr[0] = header
            //arr[1]+arr[2] = packet size
            //arr[size-3]+arr[size-2] = checksum
            //arr[size-1] = footer
            byte[] arrsize = BitConverter.GetBytes(size);
            r.NextBytes(arr);

            arr[1] = arrsize[0];
            arr[2] = arrsize[1];

            short packetchecksum = 0;
            for (int i = 3; i < size - 3; i++)
                packetchecksum += arr[i];
            byte[] packetchecksumByte = BitConverter.GetBytes(packetchecksum);
            arr[size - 3] = packetchecksumByte[0];
            arr[size - 2] = packetchecksumByte[1];

            arr[0] = 51;
            arr[size - 1] = 75;

            return arr;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            serialPort1.Write(tbTX.Text);
        }

        private void btnPortTara_Click(object sender, EventArgs e)
        {
            try
            {
                portnames.Items.Clear();
                portnames.Items.AddRange(SerialPort.GetPortNames());
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClearTX_Click(object sender, EventArgs e)
        {
            tbTX.Text = "";
        }

        private void btnClearRX_Click(object sender, EventArgs e)
        {
            tbRX.Text = "";
        }
    }

}
