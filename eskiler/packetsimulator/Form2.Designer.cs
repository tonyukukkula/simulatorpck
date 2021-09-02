
namespace packetsimulator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.alinanpaket = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.alinanbyte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(188, 12);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb1.Size = new System.Drawing.Size(307, 355);
            this.tb1.TabIndex = 0;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(137, 57);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(13, 13);
            this.labelP.TabIndex = 28;
            this.labelP.Text = "0";
            // 
            // alinanpaket
            // 
            this.alinanpaket.AutoSize = true;
            this.alinanpaket.Location = new System.Drawing.Point(37, 55);
            this.alinanpaket.Name = "alinanpaket";
            this.alinanpaket.Size = new System.Drawing.Size(65, 13);
            this.alinanpaket.TabIndex = 27;
            this.alinanpaket.Text = "alınan paket";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(137, 30);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(13, 13);
            this.labelB.TabIndex = 26;
            this.labelB.Text = "0";
            // 
            // alinanbyte
            // 
            this.alinanbyte.AutoSize = true;
            this.alinanbyte.Location = new System.Drawing.Point(37, 30);
            this.alinanbyte.Name = "alinanbyte";
            this.alinanbyte.Size = new System.Drawing.Size(58, 13);
            this.alinanbyte.TabIndex = 24;
            this.alinanbyte.Text = "alınan byte";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 402);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.alinanpaket);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.alinanbyte);
            this.Controls.Add(this.tb1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label alinanpaket;
        private System.Windows.Forms.Label alinanbyte;
        public System.Windows.Forms.TextBox tb1;
        public System.Windows.Forms.Label labelP;
        public System.Windows.Forms.Label labelB;
    }
}