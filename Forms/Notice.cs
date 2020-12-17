//MIT License
//Copyright(c) 2020 Semih Aydın
//UTF - 8

using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginSystem.Forms
{
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }

        public int pbStatus
        {
            set
            {
                if (value == 1)
                {
                    pbWarning.Visible = true;
                    pbInfo.Visible = false;
                }
                else
                {
                    pbInfo.Visible = true;
                    pbWarning.Visible = false;
                }
            }
        }

        public string NoticeText
        {
            set
            {
                this.Controls.Clear();
                this.InitializeComponent();
                lblNotice.Text = value;
                SetSize();
            }
        }

        public void SetSize()
        {
            this.Width = 250;
            if (lblNotice.Width > 180)
            {
                this.Width = lblNotice.Width - 180 + this.Width;
                pbExit.Location = new Point(this.Width - 20, 10);
            }
            else
            {
                pbExit.Location = new Point(this.Width - 20, 10);
            }
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            Main.mc = new Main.MainClass(this);
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}