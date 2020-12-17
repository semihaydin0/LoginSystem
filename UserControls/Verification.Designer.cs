namespace LoginSystem.UserControls
{
    partial class Verification
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            this.lblHeader_1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHeader_2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtVrfCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbVrfCode = new System.Windows.Forms.PictureBox();
            this.txtBottomVC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVerify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblFooter_1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFooter_2 = new System.Windows.Forms.Label();
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTimeLeft = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tmrTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.lblSecond = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbVrfCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader_1
            // 
            this.lblHeader_1.AutoSize = true;
            this.lblHeader_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader_1.Location = new System.Drawing.Point(12, 9);
            this.lblHeader_1.Name = "lblHeader_1";
            this.lblHeader_1.Size = new System.Drawing.Size(356, 17);
            this.lblHeader_1.TabIndex = 32;
            this.lblHeader_1.Text = "Your verification code has been sent to your e-mail address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddress.Location = new System.Drawing.Point(141, 47);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 17);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "E-Mail Address";
            // 
            // lblHeader_2
            // 
            this.lblHeader_2.AutoSize = true;
            this.lblHeader_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeader_2.Location = new System.Drawing.Point(85, 80);
            this.lblHeader_2.Name = "lblHeader_2";
            this.lblHeader_2.Size = new System.Drawing.Size(209, 17);
            this.lblHeader_2.TabIndex = 34;
            this.lblHeader_2.Text = "Please enter your verification code";
            // 
            // txtVrfCode
            // 
            this.txtVrfCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtVrfCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtVrfCode.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtVrfCode.HintForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtVrfCode.HintText = "Verification Code";
            this.txtVrfCode.isPassword = false;
            this.txtVrfCode.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtVrfCode.LineIdleColor = System.Drawing.Color.Silver;
            this.txtVrfCode.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtVrfCode.LineThickness = 3;
            this.txtVrfCode.Location = new System.Drawing.Point(137, 111);
            this.txtVrfCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVrfCode.Name = "txtVrfCode";
            this.txtVrfCode.Size = new System.Drawing.Size(140, 40);
            this.txtVrfCode.TabIndex = 0;
            this.txtVrfCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVrfCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVrfCode_KeyPress);
            // 
            // pbVrfCode
            // 
            this.pbVrfCode.Image = ((System.Drawing.Image)(resources.GetObject("pbVrfCode.Image")));
            this.pbVrfCode.Location = new System.Drawing.Point(104, 111);
            this.pbVrfCode.Name = "pbVrfCode";
            this.pbVrfCode.Size = new System.Drawing.Size(32, 32);
            this.pbVrfCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVrfCode.TabIndex = 36;
            this.pbVrfCode.TabStop = false;
            // 
            // txtBottomVC
            // 
            this.txtBottomVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBottomVC.Enabled = false;
            this.txtBottomVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBottomVC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBottomVC.HintForeColor = System.Drawing.Color.Empty;
            this.txtBottomVC.HintText = "";
            this.txtBottomVC.isPassword = true;
            this.txtBottomVC.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtBottomVC.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBottomVC.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtBottomVC.LineThickness = 3;
            this.txtBottomVC.Location = new System.Drawing.Point(104, 111);
            this.txtBottomVC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomVC.Name = "txtBottomVC";
            this.txtBottomVC.Size = new System.Drawing.Size(172, 40);
            this.txtBottomVC.TabIndex = 37;
            this.txtBottomVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnVerify
            // 
            this.btnVerify.ActiveBorderThickness = 1;
            this.btnVerify.ActiveCornerRadius = 20;
            this.btnVerify.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVerify.ActiveForecolor = System.Drawing.Color.White;
            this.btnVerify.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerify.BackgroundImage")));
            this.btnVerify.ButtonText = "VERIFY";
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.IdleBorderThickness = 1;
            this.btnVerify.IdleCornerRadius = 20;
            this.btnVerify.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnVerify.IdleForecolor = System.Drawing.Color.White;
            this.btnVerify.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVerify.Location = new System.Drawing.Point(105, 164);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(170, 55);
            this.btnVerify.TabIndex = 38;
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblFooter_1
            // 
            this.lblFooter_1.AutoSize = true;
            this.lblFooter_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFooter_1.Location = new System.Drawing.Point(22, 258);
            this.lblFooter_1.Name = "lblFooter_1";
            this.lblFooter_1.Size = new System.Drawing.Size(309, 17);
            this.lblFooter_1.TabIndex = 39;
            this.lblFooter_1.Text = "Didn\'t get your verification code? You can request it";
            // 
            // lblFooter_2
            // 
            this.lblFooter_2.AutoSize = true;
            this.lblFooter_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_2.Location = new System.Drawing.Point(327, 259);
            this.lblFooter_2.Name = "lblFooter_2";
            this.lblFooter_2.Size = new System.Drawing.Size(30, 15);
            this.lblFooter_2.TabIndex = 40;
            this.lblFooter_2.Text = "here";
            this.lblFooter_2.Click += new System.EventHandler(this.lblFooter_2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Yellow;
            this.lblTime.Location = new System.Drawing.Point(185, 229);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 17);
            this.lblTime.TabIndex = 44;
            this.lblTime.Text = "120";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeLeft.Location = new System.Drawing.Point(122, 229);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(68, 17);
            this.lblTimeLeft.TabIndex = 43;
            this.lblTimeLeft.Text = "Time Left :";
            // 
            // tmrTimeLeft
            // 
            this.tmrTimeLeft.Interval = 1000;
            this.tmrTimeLeft.Tick += new System.EventHandler(this.tmrTimeLeft_Tick);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSecond.Location = new System.Drawing.Point(210, 229);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(50, 17);
            this.lblSecond.TabIndex = 45;
            this.lblSecond.Text = "second";
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblFooter_2);
            this.Controls.Add(this.lblFooter_1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtVrfCode);
            this.Controls.Add(this.pbVrfCode);
            this.Controls.Add(this.txtBottomVC);
            this.Controls.Add(this.lblHeader_2);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHeader_1);
            this.Name = "Verification";
            this.Size = new System.Drawing.Size(380, 280);
            this.Load += new System.EventHandler(this.Verification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVrfCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader_1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader_2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVrfCode;
        private System.Windows.Forms.PictureBox pbVrfCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomVC;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVerify;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFooter_1;
        private System.Windows.Forms.Label lblFooter_2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimeLeft;
        private System.Windows.Forms.Timer tmrTimeLeft;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSecond;
    }
}
