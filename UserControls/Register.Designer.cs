namespace LoginSystem.UserControls
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMembershipAgr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chxbxMembershipAgr = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.txtBottomPw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtBottomUN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmailAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.txtBottomEA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblFooter_2 = new System.Windows.Forms.Label();
            this.lblFooter_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.HintForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(96, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Location = new System.Drawing.Point(105, 209);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 55);
            this.btnRegister.TabIndex = 32;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblMembershipAgr
            // 
            this.lblMembershipAgr.AutoSize = true;
            this.lblMembershipAgr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMembershipAgr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMembershipAgr.Location = new System.Drawing.Point(78, 186);
            this.lblMembershipAgr.Name = "lblMembershipAgr";
            this.lblMembershipAgr.Size = new System.Drawing.Size(252, 20);
            this.lblMembershipAgr.TabIndex = 31;
            this.lblMembershipAgr.Text = "I accept the membership agreement.";
            // 
            // chxbxMembershipAgr
            // 
            this.chxbxMembershipAgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chxbxMembershipAgr.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chxbxMembershipAgr.Checked = false;
            this.chxbxMembershipAgr.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chxbxMembershipAgr.ForeColor = System.Drawing.Color.White;
            this.chxbxMembershipAgr.Location = new System.Drawing.Point(59, 187);
            this.chxbxMembershipAgr.Name = "chxbxMembershipAgr";
            this.chxbxMembershipAgr.Size = new System.Drawing.Size(20, 20);
            this.chxbxMembershipAgr.TabIndex = 26;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(63, 132);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 32);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 29;
            this.pbPassword.TabStop = false;
            // 
            // txtBottomPw
            // 
            this.txtBottomPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBottomPw.Enabled = false;
            this.txtBottomPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBottomPw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBottomPw.HintForeColor = System.Drawing.Color.Empty;
            this.txtBottomPw.HintText = "";
            this.txtBottomPw.isPassword = true;
            this.txtBottomPw.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtBottomPw.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBottomPw.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtBottomPw.LineThickness = 3;
            this.txtBottomPw.Location = new System.Drawing.Point(63, 132);
            this.txtBottomPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomPw.Name = "txtBottomPw";
            this.txtBottomPw.Size = new System.Drawing.Size(253, 40);
            this.txtBottomPw.TabIndex = 30;
            this.txtBottomPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsername.HintForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Silver;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(96, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 40);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbUsername.Image")));
            this.pbUsername.Location = new System.Drawing.Point(63, 71);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 32);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsername.TabIndex = 28;
            this.pbUsername.TabStop = false;
            // 
            // txtBottomUN
            // 
            this.txtBottomUN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBottomUN.Enabled = false;
            this.txtBottomUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBottomUN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBottomUN.HintForeColor = System.Drawing.Color.Empty;
            this.txtBottomUN.HintText = "";
            this.txtBottomUN.isPassword = false;
            this.txtBottomUN.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtBottomUN.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBottomUN.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtBottomUN.LineThickness = 3;
            this.txtBottomUN.Location = new System.Drawing.Point(63, 71);
            this.txtBottomUN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomUN.Name = "txtBottomUN";
            this.txtBottomUN.Size = new System.Drawing.Size(253, 40);
            this.txtBottomUN.TabIndex = 27;
            this.txtBottomUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEmailAddress.HintForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEmailAddress.HintText = "E-Mail Address";
            this.txtEmailAddress.isPassword = false;
            this.txtEmailAddress.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtEmailAddress.LineIdleColor = System.Drawing.Color.Silver;
            this.txtEmailAddress.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtEmailAddress.LineThickness = 3;
            this.txtEmailAddress.Location = new System.Drawing.Point(96, 10);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(220, 40);
            this.txtEmailAddress.TabIndex = 0;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbMail
            // 
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.Location = new System.Drawing.Point(63, 10);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(32, 32);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 35;
            this.pbMail.TabStop = false;
            // 
            // txtBottomEA
            // 
            this.txtBottomEA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBottomEA.Enabled = false;
            this.txtBottomEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBottomEA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBottomEA.HintForeColor = System.Drawing.Color.Empty;
            this.txtBottomEA.HintText = "";
            this.txtBottomEA.isPassword = false;
            this.txtBottomEA.LineFocusedColor = System.Drawing.Color.Silver;
            this.txtBottomEA.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBottomEA.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtBottomEA.LineThickness = 3;
            this.txtBottomEA.Location = new System.Drawing.Point(63, 10);
            this.txtBottomEA.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomEA.Name = "txtBottomEA";
            this.txtBottomEA.Size = new System.Drawing.Size(253, 40);
            this.txtBottomEA.TabIndex = 34;
            this.txtBottomEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblFooter_2
            // 
            this.lblFooter_2.AutoSize = true;
            this.lblFooter_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_2.Location = new System.Drawing.Point(303, 265);
            this.lblFooter_2.Name = "lblFooter_2";
            this.lblFooter_2.Size = new System.Drawing.Size(30, 15);
            this.lblFooter_2.TabIndex = 37;
            this.lblFooter_2.Text = "here";
            this.lblFooter_2.Click += new System.EventHandler(this.lblFooter_2_Click);
            // 
            // lblFooter_1
            // 
            this.lblFooter_1.AutoSize = true;
            this.lblFooter_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_1.Location = new System.Drawing.Point(47, 265);
            this.lblFooter_1.Name = "lblFooter_1";
            this.lblFooter_1.Size = new System.Drawing.Size(259, 15);
            this.lblFooter_1.TabIndex = 36;
            this.lblFooter_1.Text = "Do you already have an account? You can log in";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblFooter_2);
            this.Controls.Add(this.lblFooter_1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.pbMail);
            this.Controls.Add(this.txtBottomEA);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMembershipAgr);
            this.Controls.Add(this.chxbxMembershipAgr);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.txtBottomPw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.txtBottomUN);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(380, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMembershipAgr;
        private Bunifu.Framework.UI.BunifuCheckbox chxbxMembershipAgr;
        private System.Windows.Forms.PictureBox pbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomPw;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.PictureBox pbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomUN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailAddress;
        private System.Windows.Forms.PictureBox pbMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomEA;
        private System.Windows.Forms.Label lblFooter_2;
        private System.Windows.Forms.Label lblFooter_1;
    }
}
