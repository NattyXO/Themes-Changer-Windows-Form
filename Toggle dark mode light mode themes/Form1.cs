using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toggle_dark_mode_light_mode_themes
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void picDark_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = System.Drawing.Color.Black;
            picDay.BackColor = Color.Black;
            picDark.Visible = false;
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            picDay.Visible = true;
               
        }

        private void picDay_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = System.Drawing.Color.Transparent;
            picDark.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.Transparent;
            picDay.Visible = false;
            picDark.Visible = true;

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by NattyXO \nGithub: NattyXO \nVersion: 1.0 \nAhadu Tech");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
