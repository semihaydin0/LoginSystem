//MIT License
//Copyright(c) 2021 Semih Aydın
//UTF-8

using System;
using System.Net;
using System.Drawing;
using System.Net.Mail;
using System.Management;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LoginSystem.UserControls
{
    public partial class Verification : UserControl
    {
        public Verification()
        {
            InitializeComponent();
        }

        public static int processType;
        public string Email, Username,rawUsername, Password;
        private int verificationCode;
        private int demandTime;
        private bool newRequests;

        private void VerificationService()
        {
            if (IsInternetAvailable() == true)
            {
                try
                {
                    using (MailMessage message = new MailMessage())
                    {
                        Random rnd = new Random();
                        verificationCode = rnd.Next(100000, 999999);
                        rnd = null;
                        using (SmtpClient client = new SmtpClient())
                        {
                            client.Credentials = new NetworkCredential("EMAILADDRESS", "PASSWORD");
                            client.Port = 587;
                            client.Host = "smtp.gmail.com﻿";
                            client.EnableSsl = true;
                            message.To.Add(EmailAddress);
                            message.From = new MailAddress("EMAILADDRESS", "Verification Service");
                            message.Subject = "Verification Code";
                            message.Body = verificationCode.ToString();
                            client.Send(message);
                        }
                    }
                    Forms.Main.GarbageC();
                }
                catch (Exception)
                {
                    Forms.Main.ShowNotice("An error occurred while sending the verification code.", 1);
                    ChangeControl(Forms.Main.rgs);
                }
            }
            else
            {
                Forms.Main.ShowNotice("Please check your internet connection.", 1);
                ChangeControl(Forms.Main.rgs);
            }
        }

        private void Register()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
            {
                Forms.Main.Query = "insert into Users(Username,Password,Email,MacAddress) values ('" + Username + "','" + Password + "','" + Email + "','Mac')";
                using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void saveMacAddress()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
            {
                Forms.Main.Query = "update Users set MacAddress='" + Forms.Main.SHA256Encryption(MacAddressFinder()) + "' where Email='" + EmailAddress + "'";
                using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            using (SQLiteConnection con = new SQLiteConnection("Data Source=RememberMe.sqlite;Version=3;"))
            {
                Forms.Main.Query = "delete from Usernames";
                using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            using (SQLiteConnection con = new SQLiteConnection("Data Source=RememberMe.sqlite;Version=3;"))
            {
                Forms.Main.Query = "insert into Usernames VALUES ('" + rawUsername + "')";
                using (SQLiteCommand cmd = new SQLiteCommand(Forms.Main.Query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static string MacAddressFinder()
        {
            using (ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                foreach (ManagementObject obj in manager.GetInstances())
                {
                    if ((bool)obj["IPEnabled"])
                    {
                        return obj["MacAddress"].ToString();
                    }
                }
                return String.Empty;
            }
        }

        private bool IsInternetAvailable()
        {
            try
            {
                Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (System.Net.Sockets.SocketException)
            {
                return false;
            }
        }

        private void ChangeControl(UserControl uc)
        {
            this.Parent.Controls.Add(uc);
            this.Dispose();
        }

        public string EmailAddress
        {
            get { return lblAddress.Text; }
            set
            {
                lblAddress.Text = value;
                lblAddress.Location = new Point(380 / 2 - lblAddress.Width / 2, 41);
                demandTime = 120;
                newRequests = false;
            }
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            VerificationService();
            tmrTimeLeft.Start();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtVrfCode.Text) == verificationCode)
            {
                tmrTimeLeft.Stop();
                if (processType == 1)
                {
                    try
                    {
                        Register();
                        ChangeControl(Forms.Main.lgn);
                        Forms.Main.ShowNotice("Your registration has been successfully completed. You can login.", 0);
                    }
                    catch (Exception)
                    {
                        ChangeControl(Forms.Main.rgs);
                        Forms.Main.ShowNotice("An error occurred during the registration process.", 1);
                    }
                }
                else if (processType == 2)
                {
                    try
                    {
                        saveMacAddress();
                        this.Dispose();
                        Forms.Main.ShowNotice("Your device information has been saved in the database.", 0);
                    }
                    catch (Exception)
                    {
                        ChangeControl(Forms.Main.rgs);
                        Forms.Main.ShowNotice("An error occurred while saving device information.", 1);
                    }
                }
                else
                {
                    this.Dispose();
                    Forms.Main.ShowNotice("Verification process completed successfully.", 0);
                }
            }
            else
            {
                Forms.Main.ShowNotice("You entered the wrong verification code.", 1);
            }
        }

        private void lblFooter_2_Click(object sender, EventArgs e)
        {
            if (demandTime - int.Parse(lblTime.Text) >= 30)
            {
                VerificationService();
                if (newRequests == false)
                {
                    lblHeader_1.Text = "The new verification code was sent to the email address.";
                    lblHeader_1.Location = new Point(380 / 2 - lblHeader_1.Width / 2, 9);
                    lblHeader_1.ForeColor = Color.Yellow;
                    newRequests = true;
                }
                demandTime -= 30;
            }
            else
            {
                Forms.Main.ShowNotice("You can only request a new verification code every 30 seconds.", 1);
            }
        }

        private void tmrTimeLeft_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
            if (int.Parse(lblTime.Text) == 0)
            {
                ChangeControl(Forms.Main.rgs);
                Forms.Main.ShowNotice("Your time to enter the verification code has expired.", 1);
            }
        }

        private void txtVrfCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}