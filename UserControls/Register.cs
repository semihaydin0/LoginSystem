//MIT License
//Copyright(c) 2021 Semih Aydın
//UTF-8

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LoginSystem.UserControls
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private Verification vrf;
        
        private int RecordCheck(string inputUsername, string inputEmail)
        {       
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
                {
                    Forms.Main.Query = "SELECT count(*) FROM Users WHERE Username='" + inputUsername + "'";
                    using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                    {
                        con.Open();
                        if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                        {
                            cmd.CommandText = "SELECT count(*) FROM Users WHERE Email='" + inputEmail + "'";
                            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                            {
                                return 0;
                            }
                            else
                            {
                                return 2;
                            }

                        }
                        else 
                        {
                            return 1;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 3;
            }
        }

        private bool IsValidEmail(string _email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(_email);
                return addr.Address == _email;
            }
            catch
            {
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (chxbxMembershipAgr.Checked != false)
                {
                    if (IsValidEmail(txtEmailAddress.Text) != false)
                    {
                        vrf = new Verification();
                        vrf.EmailAddress = txtEmailAddress.Text;
                        vrf.Email = txtEmailAddress.Text;
                        vrf.Username = Forms.Main.SHA256Encryption(txtUsername.Text);
                        vrf.Password = Forms.Main.SHA256Encryption(txtPassword.Text);
                        Forms.Main.processValue = RecordCheck(vrf.Username, vrf.Email);
                        if (Forms.Main.processValue == 0)
                        {
                            txtEmailAddress.Text = null;
                            txtUsername.Text = null;
                            txtPassword.Text = null;
                            vrf.processType = 1;
                            this.Parent.Controls.Add(vrf);
                            this.Parent.Controls.Remove(this);
                        }
                        else if(Forms.Main.processValue == 1)
                        {
                            txtUsername.Text = null;
                            Forms.Main.ShowNotice("This username is already taken.", 1);
                        }
                        else if(Forms.Main.processValue == 2)
                        {
                            txtEmailAddress.Text = null;
                            Forms.Main.ShowNotice("This email address is already taken.", 1);
                        }
                        else
                        {
                            Forms.Main.ShowNotice("Database error.", 1);
                        }
                        
                    }
                    else
                    {
                        Forms.Main.ShowNotice("Invalid e-mail address.", 1);
                    }
                }
                else
                {
                    Forms.Main.ShowNotice("You must accept the membership agreement.", 1);
                }
            }
            else
            {
                Forms.Main.ShowNotice("Please fill in all fields.", 1);
            }
        }

        private void lblFooter_2_Click(object sender, EventArgs e)
        {
            if (!Forms.Main.Instance._pnlContainer.Controls.ContainsKey("Login"))
            {
                this.Parent.Controls.Add(Forms.Main.lgn);
                this.Parent.Controls.Remove(this);
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}