﻿//MIT License
//Copyright(c) 2021 Semih Aydın
//UTF-8

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace LoginSystem.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private static Main _obj;
        public static MainClass mc;
        public static string Query;
        private Point lastLocation;
        public static int processValue;
        public static UserControls.Login lgn;
        public static UserControls.Register rgs;

        public class MainClass
        {
            public MainClass(Form MainForm)
            {
                RoundCorner(MainForm);
            }

            private void RoundCorner(Form MainForm)
            {
                GraphicsPath graphicpath = new GraphicsPath();
                graphicpath.StartFigure();
                graphicpath.AddArc(0, 0, 25, 25, 180, 90);
                graphicpath.AddLine(25, 0, MainForm.Width - 25, 0);
                graphicpath.AddArc(MainForm.Width - 25, 0, 25, 25, 270, 90);
                graphicpath.AddLine(MainForm.Width, 25, MainForm.Width, MainForm.Height - 25);
                graphicpath.AddArc(MainForm.Width - 25, MainForm.Height - 25, 25, 25, 0, 90);
                graphicpath.AddLine(MainForm.Width - 25, MainForm.Height, 25, MainForm.Height);
                graphicpath.AddArc(0, MainForm.Height - 25, 25, 25, 90, 90);
                graphicpath.CloseFigure();
                MainForm.Region = new Region(graphicpath);
            }
        }

        private void IsDatabaseAvailable()
        {
            try
            {
                if (!File.Exists("UserRecords.sqlite"))
                {
                    SQLiteConnection.CreateFile("UserRecords.sqlite");
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=UserRecords.sqlite;Version=3;"))
                    {
                        Query = @"CREATE TABLE Users(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT,
                               Username TEXT NOT NULL,
                               Password TEXT NOT NULL,
                               Email TEXT NOT NULL,
                               MacAddress TEXT
                            )";
                        using (SQLiteCommand cmd = new SQLiteCommand(Query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                if (!File.Exists("RememberMe.sqlite"))
                {
                    SQLiteConnection.CreateFile("RememberMe.sqlite");
                    using (SQLiteConnection con = new SQLiteConnection("Data Source=RememberMe.sqlite;Version=3;"))
                    {
                        Query = @"CREATE TABLE Usernames(
                               Username TEXT NOT NULL
                            )";
                        using (SQLiteCommand cmd = new SQLiteCommand(Query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to create the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static string SHA256Encryption(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }

        public static void ShowNotice(string _text, int _statusValue)
        {
            using (Notice ntc = new Notice())
            {
                ntc.SetNoticeText = _text;
                ntc.SetPbStatus = _statusValue;
                ntc.ShowDialog();
            }
        }

        public static Main Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Main();
                }
                return _obj;
            }
        }

        public Panel _pnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IsDatabaseAvailable();
            mc = new MainClass(this);
            lgn = new UserControls.Login();
            rgs = new UserControls.Register();
            _pnlContainer.Controls.Add(lgn);
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}