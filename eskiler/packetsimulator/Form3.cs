using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packetsimulator
{
    public partial class Form3 : Form
    {
        static Form1 form1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            if (form1.radioButton2.Checked == true)
                form1.m_port.Write(Encoding.ASCII.GetBytes(gondertext.Text), 0, Encoding.ASCII.GetBytes(gondertext.Text).Length);
        }
    }
}
