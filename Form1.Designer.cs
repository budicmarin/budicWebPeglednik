namespace budicWebPeglednik
{
    partial class Form1
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
            this.buttonNaprijed = new System.Windows.Forms.Button();
            this.buttonNatrak = new System.Windows.Forms.Button();
            this.textBoxHttps = new System.Windows.Forms.TextBox();
            this.buttonWebmail = new System.Windows.Forms.Button();
            this.buttonGmail = new System.Windows.Forms.Button();
            this.buttonIdi = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // buttonNaprijed
            // 
            this.buttonNaprijed.Location = new System.Drawing.Point(93, 12);
            this.buttonNaprijed.Name = "buttonNaprijed";
            this.buttonNaprijed.Size = new System.Drawing.Size(75, 28);
            this.buttonNaprijed.TabIndex = 0;
            this.buttonNaprijed.Text = "Naprijed";
            this.buttonNaprijed.UseVisualStyleBackColor = true;
            this.buttonNaprijed.Click += new System.EventHandler(this.buttonNaprijed_Click);
            // 
            // buttonNatrak
            // 
            this.buttonNatrak.Location = new System.Drawing.Point(12, 12);
            this.buttonNatrak.Name = "buttonNatrak";
            this.buttonNatrak.Size = new System.Drawing.Size(75, 28);
            this.buttonNatrak.TabIndex = 1;
            this.buttonNatrak.Text = "Natrag";
            this.buttonNatrak.UseVisualStyleBackColor = true;
            this.buttonNatrak.Click += new System.EventHandler(this.buttonNatrak_Click);
            // 
            // textBoxHttps
            // 
            this.textBoxHttps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHttps.Location = new System.Drawing.Point(249, 12);
            this.textBoxHttps.Multiline = true;
            this.textBoxHttps.Name = "textBoxHttps";
            this.textBoxHttps.Size = new System.Drawing.Size(428, 28);
            this.textBoxHttps.TabIndex = 2;
            this.textBoxHttps.Text = "https://";
            // 
            // buttonWebmail
            // 
            this.buttonWebmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWebmail.Location = new System.Drawing.Point(837, 12);
            this.buttonWebmail.Name = "buttonWebmail";
            this.buttonWebmail.Size = new System.Drawing.Size(75, 28);
            this.buttonWebmail.TabIndex = 3;
            this.buttonWebmail.Text = "Webmail";
            this.buttonWebmail.UseVisualStyleBackColor = true;
            this.buttonWebmail.Click += new System.EventHandler(this.buttonWebmail_Click);
            // 
            // buttonGmail
            // 
            this.buttonGmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGmail.Location = new System.Drawing.Point(757, 12);
            this.buttonGmail.Name = "buttonGmail";
            this.buttonGmail.Size = new System.Drawing.Size(75, 28);
            this.buttonGmail.TabIndex = 4;
            this.buttonGmail.Text = "Gmail";
            this.buttonGmail.UseVisualStyleBackColor = true;
            this.buttonGmail.Click += new System.EventHandler(this.buttonGmail_Click);
            // 
            // buttonIdi
            // 
            this.buttonIdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIdi.Location = new System.Drawing.Point(683, 12);
            this.buttonIdi.Name = "buttonIdi";
            this.buttonIdi.Size = new System.Drawing.Size(47, 28);
            this.buttonIdi.TabIndex = 5;
            this.buttonIdi.Text = "Idi";
            this.buttonIdi.UseVisualStyleBackColor = true;
            this.buttonIdi.Click += new System.EventHandler(this.buttonIdi_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIspis.Location = new System.Drawing.Point(918, 12);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(75, 28);
            this.buttonIspis.TabIndex = 6;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(184, 18);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(53, 17);
            this.labelAdresa.TabIndex = 7;
            this.labelAdresa.Text = "Adresa";
            this.labelAdresa.Click += new System.EventHandler(this.labelAdresa_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(13, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(980, 409);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 420);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonIdi);
            this.Controls.Add(this.buttonGmail);
            this.Controls.Add(this.buttonWebmail);
            this.Controls.Add(this.textBoxHttps);
            this.Controls.Add(this.buttonNatrak);
            this.Controls.Add(this.buttonNaprijed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNaprijed;
        private System.Windows.Forms.Button buttonNatrak;
        private System.Windows.Forms.TextBox textBoxHttps;
        private System.Windows.Forms.Button buttonWebmail;
        private System.Windows.Forms.Button buttonGmail;
        private System.Windows.Forms.Button buttonIdi;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

