using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LabelUserName.Text = "Sessió iniciada com a: " + FormLogin.Username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMaximizeWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.BackgroundImage = Properties.Resources.Fons_complet_reduit;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.Fons;
            }
        }

        private void LabelProgramTitle_Click(object sender, EventArgs e)
        {

        }

        //private void TopPanel_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void ButtonFullScreen_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size && this.Location == Screen.PrimaryScreen.WorkingArea.Location)
            {
                this.Size = new Size(1200, 561);
                this.CenterToScreen();
                this.BackgroundImage = Properties.Resources.Fons_complet_reduit;
            } else
            {
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.BackgroundImage = Properties.Resources.Fons;
            }
        }

        private void ButtonMinimizeScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
