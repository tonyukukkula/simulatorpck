
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
            this.tbRX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTX = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
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
            this.tbsizeofpacket = new System.Windows.Forms.TextBox();
            this.Lpacketsize = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnPortTara = new System.Windows.Forms.Button();
            this.btnClearTX = new System.Windows.Forms.Button();
            this.btnClearRX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tbRX
            // 
            this.tbRX.Location = new System.Drawing.Point(260, 261);
            this.tbRX.Multiline = true;
            this.tbRX.Name = "tbRX";
            this.tbRX.ReadOnly = true;
            this.tbRX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRX.Size = new System.Drawing.Size(244, 155);
            this.tbRX.TabIndex = 0;
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
            // tbTX
            // 
            this.tbTX.Location = new System.Drawing.Point(12, 261);
            this.tbTX.Multiline = true;
            this.tbTX.Name = "tbTX";
            this.tbTX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTX.Size = new System.Drawing.Size(217, 155);
            this.tbTX.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(154, 422);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Lportname
            // 
            this.Lportname.AutoSize = true;
            this.Lportname.Location = new System.Drawing.Point(23, 37);
            this.Lportname.Name = "Lportname";
            this.Lportname.Size = new System.Drawing.Size(25, 13);
            this.Lportname.TabIndex = 10;
            this.Lportname.Text = "port";
            // 
            // Lbaudrate
            // 
            this.Lbaudrate.AutoSize = true;
            this.Lbaudrate.Location = new System.Drawing.Point(23, 63);
            this.Lbaudrate.Name = "Lbaudrate";
            this.Lbaudrate.Size = new System.Drawing.Size(49, 13);
            this.Lbaudrate.TabIndex = 11;
            this.Lbaudrate.Text = "baudrate";
            // 
            // Ldatabits
            // 
            this.Ldatabits.AutoSize = true;
            this.Ldatabits.Location = new System.Drawing.Point(23, 89);
            this.Ldatabits.Name = "Ldatabits";
            this.Ldatabits.Size = new System.Drawing.Size(47, 13);
            this.Ldatabits.TabIndex = 12;
            this.Ldatabits.Text = "data bits";
            // 
            // Lstopbits
            // 
            this.Lstopbits.AutoSize = true;
            this.Lstopbits.Location = new System.Drawing.Point(23, 115);
            this.Lstopbits.Name = "Lstopbits";
            this.Lstopbits.Size = new System.Drawing.Size(46, 13);
            this.Lstopbits.TabIndex = 13;
            this.Lstopbits.Text = "stop bits";
            // 
            // Lparitybits
            // 
            this.Lparitybits.AutoSize = true;
            this.Lparitybits.Location = new System.Drawing.Point(23, 141);
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
            // tbsizeofpacket
            // 
            this.tbsizeofpacket.Location = new System.Drawing.Point(349, 39);
            this.tbsizeofpacket.Name = "tbsizeofpacket";
            this.tbsizeofpacket.Size = new System.Drawing.Size(100, 20);
            this.tbsizeofpacket.TabIndex = 22;
            // 
            // Lpacketsize
            // 
            this.Lpacketsize.AutoSize = true;
            this.Lpacketsize.Location = new System.Drawing.Point(257, 42);
            this.Lpacketsize.Name = "Lpacketsize";
            this.Lpacketsize.Size = new System.Drawing.Size(86, 13);
            this.Lpacketsize.TabIndex = 23;
            this.Lpacketsize.Text = "paket büyüklüğü";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(468, 37);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 24;
            this.btnOlustur.Text = "oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnPortTara
            // 
            this.btnPortTara.Location = new System.Drawing.Point(154, 5);
            this.btnPortTara.Name = "btnPortTara";
            this.btnPortTara.Size = new System.Drawing.Size(75, 23);
            this.btnPortTara.TabIndex = 25;
            this.btnPortTara.Text = "Port Tara";
            this.btnPortTara.UseVisualStyleBackColor = true;
            this.btnPortTara.Click += new System.EventHandler(this.btnPortTara_Click);
            // 
            // btnClearTX
            // 
            this.btnClearTX.Location = new System.Drawing.Point(349, 422);
            this.btnClearTX.Name = "btnClearTX";
            this.btnClearTX.Size = new System.Drawing.Size(75, 23);
            this.btnClearTX.TabIndex = 26;
            this.btnClearTX.Text = "TX Temizle";
            this.btnClearTX.UseVisualStyleBackColor = true;
            this.btnClearTX.Click += new System.EventHandler(this.btnClearTX_Click);
            // 
            // btnClearRX
            // 
            this.btnClearRX.Location = new System.Drawing.Point(463, 422);
            this.btnClearRX.Name = "btnClearRX";
            this.btnClearRX.Size = new System.Drawing.Size(75, 23);
            this.btnClearRX.TabIndex = 27;
            this.btnClearRX.Text = "RX Temizle";
            this.btnClearRX.UseVisualStyleBackColor = true;
            this.btnClearRX.Click += new System.EventHandler(this.btnClearRX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnClearRX);
            this.Controls.Add(this.btnClearTX);
            this.Controls.Add(this.btnPortTara);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.Lpacketsize);
            this.Controls.Add(this.tbsizeofpacket);
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
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbRX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTX;
        private System.Windows.Forms.Button btnGonder;
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
        private System.Windows.Forms.TextBox tbsizeofpacket;
        private System.Windows.Forms.Label Lpacketsize;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnPortTara;
        private System.Windows.Forms.Button btnClearTX;
        private System.Windows.Forms.Button btnClearRX;
    }
}

