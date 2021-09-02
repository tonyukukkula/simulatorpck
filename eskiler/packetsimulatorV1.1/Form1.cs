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
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxport.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnbaudEkle_Click(object sender, EventArgs e)
        {
            int baudR = Convert.ToInt32(textBoxbaud.Text);
            comboBoxbaud.Items.Add(baudR);
        }

        private void btnportTara_Click(object sender, EventArgs e)
        {
            comboBoxport.Items.Clear();
            comboBoxport.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnbaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_port.IsOpen)
                {
                    btnbaglan.Text = "bağlan";
                    btnbaglan.BackColor = Color.Red;
                    m_port.Close();
                    btnbaslat.Visible = false;
                }
                else
                {
                    m_port = new SerialPort(comboBoxport.GetItemText(comboBoxport.SelectedItem),
                        Convert.ToInt32(comboBoxbaud.GetItemText(comboBoxbaud.SelectedItem)),
                        (Parity)Enum.Parse(typeof(Parity), paritybitsCombo.GetItemText(paritybitsCombo.SelectedItem)),
                        Convert.ToInt32(databitsCombo.GetItemText(databitsCombo.SelectedItem)),
                        (StopBits)Enum.Parse(typeof(StopBits),stopbitsCombo.GetItemText(stopbitsCombo.SelectedItem))
                        );
                    m_port.Handshake = Handshake.None;
                    m_port.RtsEnable = true;
                    m_port.DtrEnable = true;
                    m_port.Open();
                    btnbaglan.Text = "bağlantıyı kes";
                    btnbaglan.BackColor = Color.Green;
                    btnbaslat.Visible = true;
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        public void write_pct(byte [] packet, Label labelB, Label LabelP) {
            m_port.Write(packet, 0, packet.Length);
            for (int i = 0; i < packet.Length; labelinc(labelB), Thread.Sleep(1), i++) { }
            labelinc(LabelP);
        }
        public void read_pct(byte [] packet_r, Label labelB, Label LabelP) {
            m_port.Read(packet_r, 0, packet_r.Length);
            for (int i = 0; i < packet_r.Length; labelinc(labelB), Thread.Sleep(1), i++) { }
            labelinc(LabelP);
        }
        public void compare_pct() {
            byte[] pack = create_pct();
            write_pct(pack, labelGonderilenB, labelGonderilenP);

            byte[] r_pack = new byte[10];
            read_pct(r_pack, labelAlinanB, labelAlinanP);

            compare(pack, r_pack);
        }
        public void compare(byte[] pack, byte[] r_pack) {
            foreach (var p in pack)
            {
                if (pack[p] == r_pack[p])
                {
                    labelinc(labelEslesenB);
                }
                else 
                {
                    labelinc(labelHataliB);
                }
            }
            if (r_pack == pack)
            {
                labelinc(labelEslesenP);
            }
            else
            {
                labelinc(labelHataliP);
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

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            if (radioButtonRX.Checked == true)
            {
                Task.Factory.StartNew(() => form2.ShowDialog());
            }
            else if (radioButtonTX.Checked == true)
            {
                Task.Factory.StartNew(() => form3.ShowDialog());
            }
            else if (radioButtonCompare.Checked == true) {
                for (int i = 0; i < Convert.ToInt32(textBoxpaketsayisi.Text); compare_pct(), i++) { }     
            }
                
        }
        public void oku() {
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCompare.Checked == true)
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }
    }
}
