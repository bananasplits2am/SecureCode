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
    public partial class FormLoadingScreen : Form
    {
        public FormLoadingScreen()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //ProgressBarSplashScreen.ForeColor = Color.Red;
        }

        private void TimerSplashScreen_Tick(object sender, EventArgs e)
        {
            ProgressBarSplashScreen.ForeColor = Color.FromArgb(255, 235, 27, 36);
            ProgressBarSplashScreen.BackColor = Color.FromArgb(255, 30, 29, 47);
            ProgressBarSplashScreen.Increment(1);

            if (ProgressBarSplashScreen.Value == ProgressBarSplashScreen.Maximum)
            {
                TimerSplashScreen.Stop();
                this.Hide();
                FormLogin frmlogin = new FormLogin();
                frmlogin.ShowDialog();
            }
        }

    }
}
