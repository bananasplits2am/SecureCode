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
        private bool arrastrar = false;
        int acceslevel = FormLogin.acceslevel;
        private Point posicionInicio = new Point(0, 0);

        public MainForm()
        {
            InitializeComponent();
            LabelUser.Text = "Sessió iniciada com a";
            labelRango.Text = FormLogin.nombreRango;
            LabelUserName.Text = FormLogin.DatosUser[0];
            //MessageBox.Show(acceslevel.ToString());
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                buttonMin.BackgroundImage = Properties.Resources.icons8_macos_maximize_60;
                this.WindowState = FormWindowState.Normal;
                this.BackgroundImage = Properties.Resources.Fons_complet_reduit;
                this.CenterToScreen();
            } else if (this.WindowState == FormWindowState.Normal)
            {
                buttonMin.BackgroundImage = Properties.Resources.icons8macosminimizar60;
                this.WindowState = FormWindowState.Maximized;
                this.BackgroundImage = Properties.Resources.Fons;
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (panelInfo.Visible == false)
            {
                panelInfo.Visible = true;
            } else
            {
                panelInfo.Visible = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           //pictureUser.
        }

        private void buttonTencarSessio_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            this.Close();
            this.Hide(); //mirar como solo usar el hide
            Login.ShowDialog();

        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            posicionInicio = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {           
            if (arrastrar)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.posicionInicio.X, p.Y - this.posicionInicio.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }

        private void swLlenca1_Load(object sender, EventArgs e)
        {

        }
    }
}
