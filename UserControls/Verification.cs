﻿//MIT License
//Copyright(c) 2020 Semih Aydın
//UTF - 8

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
        public string Email, Username, Password;
        private int verificationCode;
        private int demandTime;
        private bool newRequests;

        private void VerificationService()
        {
            if (IsInternetAvailable() == true)
            {
                try
                {
                    Random rnd = new Random();
                    MailMessage message = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    verificationCode = rnd.Next(100000, 999999);
                    client.Credentials = new System.Net.NetworkCredential("EMAILADDRESS", "PASSWORD");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com﻿";
                    client.EnableSsl = true;
                    message.To.Add(EmailAddress);
                    message.From = new MailAddress("EMAILADDRESS", "Verification Service");
                    message.Subject = "Verification Code";
                    message.Body = verificationCode.ToString();
                    client.Send(message);
                    rnd = null;
                    message = null;
                    client = null;
                    Forms.Main.GarbageC();
                }
                catch (Exception)
                {
                    Forms.Main.ntc.NoticeText = "An error occurred while sending the verification code.";
                    Forms.Main.ntc.pbStatus = 1;
                    ChangeControl(Forms.Main.rgs);
                }
            }
            else
            {
                Forms.Main.ntc.NoticeText = "Please check your internet connection.";
                Forms.Main.ntc.pbStatus = 1;
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
            this.Parent.Controls.Remove(this);
            Forms.Main.GarbageC();
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
                        this.Parent.Controls.Remove(this);
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
                    this.Parent.Controls.Remove(this);
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