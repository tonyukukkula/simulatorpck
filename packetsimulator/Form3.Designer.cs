
namespace packetsimulator
{
    partial class Form3
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
            this.gondertext = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gondertext
            // 
            this.gondertext.Location = new System.Drawing.Point(12, 12);
            this.gondertext.Multiline = true;
            this.gondertext.Name = "gondertext";
            this.gondertext.Size = new System.Drawing.Size(331, 288);
            this.gondertext.TabIndex = 0;
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(372, 81);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(75, 23);
            this.gonder.TabIndex = 1;
            this.gonder.Text = "gonder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 323);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.gondertext);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox gondertext;
        public System.Windows.Forms.Button gonder;
    }
}