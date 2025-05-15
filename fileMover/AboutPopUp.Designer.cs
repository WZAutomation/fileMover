namespace fileMover
{
    partial class AboutPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPopUp));
            pictureBox1 = new PictureBox();
            aboutInfo = new Label();
            sourceLink = new LinkLabel();
            commitNum = new Label();
            wzautomationurl = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WZAutomationLogo;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // aboutInfo
            // 
            aboutInfo.AutoSize = true;
            aboutInfo.Location = new Point(12, 270);
            aboutInfo.Name = "aboutInfo";
            aboutInfo.Size = new Size(264, 120);
            aboutInfo.TabIndex = 1;
            aboutInfo.Text = "fileMover tool made for Vanderlande Hong Kong\r\nInternational Airport 3RS project.\r\n\r\nRelease Version:\r\n\r\nContact: \r\n\r\nSource:";
            // 
            // sourceLink
            // 
            sourceLink.AutoSize = true;
            sourceLink.Location = new Point(54, 375);
            sourceLink.Name = "sourceLink";
            sourceLink.Size = new Size(251, 15);
            sourceLink.TabIndex = 2;
            sourceLink.TabStop = true;
            sourceLink.Text = "https://github.com/WZAutomation/fileMover";
            sourceLink.LinkClicked += AboutLinkClicked;
            // 
            // commitNum
            // 
            commitNum.AutoSize = true;
            commitNum.Location = new Point(100, 316);
            commitNum.Name = "commitNum";
            commitNum.Size = new Size(102, 15);
            commitNum.TabIndex = 3;
            commitNum.Text = "VERSIONNUMBER";
            // 
            // wzautomationurl
            // 
            wzautomationurl.AutoSize = true;
            wzautomationurl.Location = new Point(60, 345);
            wzautomationurl.Name = "wzautomationurl";
            wzautomationurl.Size = new Size(185, 15);
            wzautomationurl.TabIndex = 4;
            wzautomationurl.TabStop = true;
            wzautomationurl.Text = "https://www.wzautomation.com/";
            wzautomationurl.LinkClicked += WzautomationurlLinkClicked;
            // 
            // AboutPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 420);
            Controls.Add(wzautomationurl);
            Controls.Add(commitNum);
            Controls.Add(sourceLink);
            Controls.Add(aboutInfo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutPopUp";
            Text = "AboutPopUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private PictureBox pictureBox1;
        private Label aboutInfo;
        private LinkLabel sourceLink;
        private Label commitNum;
        private LinkLabel wzautomationurl;
    }
}