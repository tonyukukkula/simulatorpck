
namespace pcksimulatorv2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lportname = new System.Windows.Forms.Label();
            this.Lbaudrate = new System.Windows.Forms.Label();
            this.Ldatabits = new System.Windows.Forms.Label();
            this.Lstopbits = new System.Windows.Forms.Label();
            this.Lparitybits = new System.Windows.Forms.Label();
            this.btnport = new System.Windows.Forms.Button();
            this.Lportstatus = new System.Windows.Forms.Label();
            this.portnames = new System.Windows.Forms.ComboBox();
            this.baudrates = new System.Windows.Forms.ComboBox();
            this.databitss = new System.Windows.Forms.ComboBox();
            this.stopbitss = new System.Windows.Forms.ComboBox();
            this.paritybitss = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 261);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(244, 155);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "TX:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 261);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(217, 155);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gonder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lportname
            // 
            this.Lportname.AutoSize = true;
            this.Lportname.Location = new System.Drawing.Point(23, 42);
            this.Lportname.Name = "Lportname";
            this.Lportname.Size = new System.Drawing.Size(25, 13);
            this.Lportname.TabIndex = 10;
            this.Lportname.Text = "port";
            // 
            // Lbaudrate
            // 
            this.Lbaudrate.AutoSize = true;
            this.Lbaudrate.Location = new System.Drawing.Point(23, 68);
            this.Lbaudrate.Name = "Lbaudrate";
            this.Lbaudrate.Size = new System.Drawing.Size(49, 13);
            this.Lbaudrate.TabIndex = 11;
            this.Lbaudrate.Text = "baudrate";
            // 
            // Ldatabits
            // 
            this.Ldatabits.AutoSize = true;
            this.Ldatabits.Location = new System.Drawing.Point(23, 94);
            this.Ldatabits.Name = "Ldatabits";
            this.Ldatabits.Size = new System.Drawing.Size(47, 13);
            this.Ldatabits.TabIndex = 12;
            this.Ldatabits.Text = "data bits";
            // 
            // Lstopbits
            // 
            this.Lstopbits.AutoSize = true;
            this.Lstopbits.Location = new System.Drawing.Point(23, 120);
            this.Lstopbits.Name = "Lstopbits";
            this.Lstopbits.Size = new System.Drawing.Size(46, 13);
            this.Lstopbits.TabIndex = 13;
            this.Lstopbits.Text = "stop bits";
            // 
            // Lparitybits
            // 
            this.Lparitybits.AutoSize = true;
            this.Lparitybits.Location = new System.Drawing.Point(23, 146);
            this.Lparitybits.Name = "Lparitybits";
            this.Lparitybits.Size = new System.Drawing.Size(51, 13);
            this.Lparitybits.TabIndex = 14;
            this.Lparitybits.Text = "parity bits";
            // 
            // btnport
            // 
            this.btnport.Location = new System.Drawing.Point(108, 165);
            this.btnport.Name = "btnport";
            this.btnport.Size = new System.Drawing.Size(101, 28);
            this.btnport.TabIndex = 15;
            this.btnport.Text = "Port Aç";
            this.btnport.UseVisualStyleBackColor = true;
            this.btnport.Click += new System.EventHandler(this.btnport_Click);
            // 
            // Lportstatus
            // 
            this.Lportstatus.AutoSize = true;
            this.Lportstatus.ForeColor = System.Drawing.Color.Red;
            this.Lportstatus.Location = new System.Drawing.Point(23, 177);
            this.Lportstatus.Name = "Lportstatus";
            this.Lportstatus.Size = new System.Drawing.Size(58, 13);
            this.Lportstatus.TabIndex = 16;
            this.Lportstatus.Text = "Port Kapalı";
            // 
            // portnames
            // 
            this.portnames.FormattingEnabled = true;
            this.portnames.Location = new System.Drawing.Point(108, 34);
            this.portnames.Name = "portnames";
            this.portnames.Size = new System.Drawing.Size(121, 21);
            this.portnames.TabIndex = 17;
            // 
            // baudrates
            // 
            this.baudrates.FormattingEnabled = true;
            this.baudrates.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "134",
            "150",
            "200",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudrates.Location = new System.Drawing.Point(108, 60);
            this.baudrates.Name = "baudrates";
            this.baudrates.Size = new System.Drawing.Size(121, 21);
            this.baudrates.TabIndex = 18;
            // 
            // databitss
            // 
            this.databitss.FormattingEnabled = true;
            this.databitss.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.databitss.Location = new System.Drawing.Point(108, 86);
            this.databitss.Name = "databitss";
            this.databitss.Size = new System.Drawing.Size(121, 21);
            this.databitss.TabIndex = 19;
            // 
            // stopbitss
            // 
            this.stopbitss.FormattingEnabled = true;
            this.stopbitss.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.stopbitss.Location = new System.Drawing.Point(108, 112);
            this.stopbitss.Name = "stopbitss";
            this.stopbitss.Size = new System.Drawing.Size(121, 21);
            this.stopbitss.TabIndex = 20;
            // 
            // paritybitss
            // 
            this.paritybitss.FormattingEnabled = true;
            this.paritybitss.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.paritybitss.Location = new System.Drawing.Point(108, 138);
            this.paritybitss.Name = "paritybitss";
            this.paritybitss.Size = new System.Drawing.Size(121, 21);
            this.paritybitss.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.paritybitss);
            this.Controls.Add(this.stopbitss);
            this.Controls.Add(this.databitss);
            this.Controls.Add(this.baudrates);
            this.Controls.Add(this.portnames);
            this.Controls.Add(this.Lportstatus);
            this.Controls.Add(this.btnport);
            this.Controls.Add(this.Lparitybits);
            this.Controls.Add(this.Lstopbits);
            this.Controls.Add(this.Ldatabits);
            this.Controls.Add(this.Lbaudrate);
            this.Controls.Add(this.Lportname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lportname;
        private System.Windows.Forms.Label Lbaudrate;
        private System.Windows.Forms.Label Ldatabits;
        private System.Windows.Forms.Label Lstopbits;
        private System.Windows.Forms.Label Lparitybits;
        private System.Windows.Forms.Button btnport;
        private System.Windows.Forms.Label Lportstatus;
        private System.Windows.Forms.ComboBox portnames;
        private System.Windows.Forms.ComboBox baudrates;
        private System.Windows.Forms.ComboBox databitss;
        private System.Windows.Forms.ComboBox stopbitss;
        private System.Windows.Forms.ComboBox paritybitss;
    }
}

