//MIT License
//Copyright(c) 2021 Semih Aydın
//UTF-8

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

        const int defaultWidth = 250;
        private bool mouseDown;
        private Point lastLocation;

        public void SetPbStatus(int value)
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

        public void SetNoticeText(string value)
        {
            lblNotice.Text = value;
            SetSize();
        }

        private void SetSize()
        {
            if (lblNotice.Width > 220)
            {
                this.Width = lblNotice.Width - 135 + defaultWidth;
            }
            pbExit.Location = new Point(this.Width - 20, 10);
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            Main.mc = new Main.MainClass(this);
        }

        private void Notice_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Notice_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Notice_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}