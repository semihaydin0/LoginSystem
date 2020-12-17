//MIT License
//Copyright(c) 2020 Semih Aydın
//UTF - 8

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LoginSystem.UserControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private Verification vrf;
        public static string _email;
        
        private int recordControl(string _username, string _password)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
                {
                    Forms.Main.Query = "SELECT * FROM Users where Username='" + _username + "' AND Password='" + _password + "'";
                    using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                    {
                        con.Open();
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return 0;
                            }
                            else
                            {
                                return 1;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 2;
            }
        }
        private int macAddressControl(string _username)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
                {
                    Forms.Main.Query = "SELECT MacAddress,Email FROM Users where Username='" + _username + "'";
                    using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                    {
                        con.Open();
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                _email = dr.GetValue(1).ToString();
                                if (dr.GetValue(0).ToString() == Forms.Main.SHA256Encryption(Verification.MacAddressFinder()))
                                {
                                    return 0;
                                }
                                else
                                {
                                    return 1;
                                }
                            }
                            else
                            {
                                return 2;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 2;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" || txtPassword.Text != "")
            {
                Forms.Main.processValue = recordControl(Forms.Main.SHA256Encryption(txtUsername.Text), Forms.Main.SHA256Encryption(txtPassword.Text));
                if (Forms.Main.processValue == 0)
                {
                    Forms.Main.processValue = macAddressControl(Forms.Main.SHA256Encryption(txtUsername.Text));
                    if (Forms.Main.processValue == 0)
                    {
                        this.Parent.Controls.Remove(this);
                        Forms.Main.ShowNotice("Login successful.", 0);
                    }
                    else if (Forms.Main.processValue == 1)
                    {
                        if (chxbxRememberMe.Checked == true)
                        {
                            Verification.processType = 2;
                        }
                        else Verification.processType = 3;
                        vrf = new Verification();
                        vrf.EmailAddress = _email;
                        this.Parent.Controls.Add(vrf);
                        this.Parent.Controls.Remove(this);
                    }
                    else
                    {
                        Forms.Main.ShowNotice("Database error.", 1);
                    }
                }
                else if (Forms.Main.processValue == 1)
                {
                    Forms.Main.ShowNotice("Wrong username or password.", 1);
                }
                else
                {
                    Forms.Main.ShowNotice("Database error.", 1);
                }
            }
            else
            {
                Forms.Main.ShowNotice("Please fill in all fields.", 1);
            }
            vrf = null;
            Forms.Main.GarbageC();
        }

        private void lblFooter_2_Click(object sender, EventArgs e)
        {
            if (!Forms.Main.Instance._pnlContainer.Controls.ContainsKey("Register"))
            {
                this.Parent.Controls.Add(Forms.Main.rgs);
                this.Parent.Controls.Remove(this);
                Forms.Main.GarbageC();
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}