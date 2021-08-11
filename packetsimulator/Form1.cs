using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace packetsimulator
{
    public partial class Form1 : Form
    {
        public SerialPort m_port = new SerialPort();
        static Form2 form2 = new Form2();
        static Form3 form3 = new Form3();
        //public static Thread thread;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int baudR = Convert.ToInt32(textBox1.Text);
            comboBox2.Items.Add(baudR);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_port.IsOpen)
                {
                    button1.Text = "bağlan";
                    m_port.Close();
                    button2.Visible = true;
                }
                else
                {
                    m_port = new SerialPort(comboBox1.GetItemText(comboBox1.SelectedItem), Convert.ToInt32(comboBox1.GetItemText(comboBox2.SelectedItem)), Parity.None, 8, StopBits.One);
                    m_port.Handshake = Handshake.None;
                    m_port.RtsEnable = true;
                    m_port.DtrEnable = true;
                    m_port.Open();
                    button1.Text = "bağlantıyı kes";
                    button2.Visible = true;
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        public void write_pct(byte [] packet) {
            m_port.Write(packet, 0, packet.Length);
        }
        public void read_pct(byte [] packet_r) {
            m_port.Read(packet_r, 0, packet_r.Length);
        }
        public void compare_pct() {
            byte[] pack = create_pct();
            write_pct(pack);
            for (int i = 0; i < 10; labelinc(label17),Thread.Sleep(1), i++) {  }
            labelinc(label28);



            byte[] r_pack = new byte[10];
            read_pct(r_pack);
            for (int i = 0; i < 10; labelinc(label18), Thread.Sleep(1), i++) { }
            labelinc(label31);


            compare(pack, r_pack);
        }
        public void compare(byte[] pack, byte[] r_pack) {
            foreach (var p in pack)
            {
                if (pack[p] == r_pack[p])
                {
                    labelinc(label19);
                }
                else 
                {
                    labelinc(label21);
                }
                if (r_pack == pack)
                {
                    labelinc(label20);
                }
                else
                {
                    labelinc(label24);
                }

            }
        }
        public void labelinc(Label x) {
            x.Text = Convert.ToString(Convert.ToInt32(x.Text) + 1);
        }
        public byte[] create_pct() {
            Random rnd = new Random();
            byte[] barr= new byte[10];
            rnd.NextBytes(barr);
            barr[0] = 46;
            barr[9] = 51;
            return barr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                form2.Show();
                Task.Factory.StartNew(() => oku());
            }
            else if (radioButton2.Checked == true)
            {
                form3.Show();
            }
            else if (radioButton3.Checked == true) {
                for (int i = 0; i < Convert.ToInt32(textBox2.Text); compare_pct(), i++) { }     
            }
                
        }
        public void oku() {
            if (radioButton1.Checked == true)
                while(button1.Text == "bağlantıyı kes" && radioButton1.Checked == true)
                {
                    byte[] alinan = new byte[10];
                    read_pct(alinan);
                    form2.tb1.Text += Encoding.ASCII.GetString(alinan);
                    for (int i = 0; i < 10; labelinc(form2.labelB), Thread.Sleep(1), i++) { }
                    Thread.Sleep(2);
                    labelinc(form2.labelP);
                }
        }

    }
}
