namespace LoginSystem.UserControls
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblFooter_2 = new System.Windows.Forms.Label();
            this.lblFooter_1 = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblRememberMe = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chxbxRememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.txtBottomPw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtBottomUN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter_2
            // 
            this.lblFooter_2.AutoSize = true;
            this.lblFooter_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_2.Location = new System.Drawing.Point(300, 255);
            this.lblFooter_2.Name = "lblFooter_2";
            this.lblFooter_2.Size = new System.Drawing.Size(30, 15);
            this.lblFooter_2.TabIndex = 25;
            this.lblFooter_2.Text = "here";
            this.lblFooter_2.Click += new System.EventHandler(this.lblFooter_2_Click);
            // 
            // lblFooter_1
            // 
            this.lblFooter_1.AutoSize = true;
            this.lblFooter_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_1.Location = new System.Drawing.Point(52, 255);
            this.lblFooter_1.Name = "lblFooter_1";
            this.lblFooter_1.Size = new System.Drawing.Size(251, 15);
            this.lblFooter_1.TabIndex = 24;
            this.lblFooter_1.Text = "If you don\'t have an account, you can create it";
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(105, 186);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 55);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRememberMe
            // 
            this.lblRememberMe.AutoSize = true;
            this.lblRememberMe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRememberMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRememberMe.Location = new System.Drawing.Point(148, 151);
            this.lblRememberMe.Name = "lblRememberMe";
            this.lblRememberMe.Size = new System.Drawing.Size(107, 20);
            this.lblRememberMe.TabIndex = 22;
            this.lblRememberMe.Text = "Remember Me";
            // 
            // chxbxRememberMe
            // 
            this.chxbxRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chxbxRememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chxbxRememberMe.Checked = false;
            this.chxbxRememberMe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chxbxRememberMe.ForeColor = System.Drawing.Color.White;
            this.chxbxRememberMe.Location = new System.Drawing.Point(129, 152);
            this.chxbxRememberMe.Name = "chxbxRememberMe";
            this.chxbxRememberMe.Size = new System.Drawing.Size(20, 20);
            this.chxbxRememberMe.TabIndex = 3;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(64, 89);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 32);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 19;
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
            this.txtBottomPw.Location = new System.Drawing.Point(64, 89);
            this.txtBottomPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomPw.Name = "txtBottomPw";
            this.txtBottomPw.Size = new System.Drawing.Size(253, 40);
            this.txtBottomPw.TabIndex = 20;
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
            this.txtUsername.Location = new System.Drawing.Point(97, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 40);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbUsername.Image")));
            this.pbUsername.Location = new System.Drawing.Point(64, 23);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 32);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsername.TabIndex = 16;
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
            this.txtBottomUN.Location = new System.Drawing.Point(64, 23);
            this.txtBottomUN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBottomUN.Name = "txtBottomUN";
            this.txtBottomUN.Size = new System.Drawing.Size(253, 40);
            this.txtBottomUN.TabIndex = 15;
            this.txtBottomUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtPassword.Location = new System.Drawing.Point(97, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblFooter_2);
            this.Controls.Add(this.lblFooter_1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRememberMe);
            this.Controls.Add(this.chxbxRememberMe);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.txtBottomPw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.txtBottomUN);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(380, 280);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFooter_2;
        private System.Windows.Forms.Label lblFooter_1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRememberMe;
        private Bunifu.Framework.UI.BunifuCheckbox chxbxRememberMe;
        private System.Windows.Forms.PictureBox pbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomPw;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.PictureBox pbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBottomUN;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
    }
}
