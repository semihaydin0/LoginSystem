namespace LoginSystem.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbTwitter = new System.Windows.Forms.PictureBox();
            this.pbInstagram = new System.Windows.Forms.PictureBox();
            this.pbFacebook = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(120, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 140);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbTwitter
            // 
            this.pbTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pbTwitter.Image")));
            this.pbTwitter.Location = new System.Drawing.Point(60, 450);
            this.pbTwitter.Name = "pbTwitter";
            this.pbTwitter.Size = new System.Drawing.Size(24, 24);
            this.pbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwitter.TabIndex = 6;
            this.pbTwitter.TabStop = false;
            // 
            // pbInstagram
            // 
            this.pbInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInstagram.Image = ((System.Drawing.Image)(resources.GetObject("pbInstagram.Image")));
            this.pbInstagram.Location = new System.Drawing.Point(35, 450);
            this.pbInstagram.Name = "pbInstagram";
            this.pbInstagram.Size = new System.Drawing.Size(24, 24);
            this.pbInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInstagram.TabIndex = 5;
            this.pbInstagram.TabStop = false;
            // 
            // pbFacebook
            // 
            this.pbFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pbFacebook.Image")));
            this.pbFacebook.Location = new System.Drawing.Point(10, 450);
            this.pbFacebook.Name = "pbFacebook";
            this.pbFacebook.Size = new System.Drawing.Size(24, 24);
            this.pbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFacebook.TabIndex = 4;
            this.pbFacebook.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(355, 10);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(12, 12);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 9;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(0, 164);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(380, 280);
            this.pnlContainer.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(380, 480);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbTwitter);
            this.Controls.Add(this.pbInstagram);
            this.Controls.Add(this.pbFacebook);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbTwitter;
        private System.Windows.Forms.PictureBox pbInstagram;
        private System.Windows.Forms.PictureBox pbFacebook;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel pnlContainer;
    }
}