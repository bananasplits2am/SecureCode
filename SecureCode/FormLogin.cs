﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SecureCode
{
    public partial class FormLogin : Form
    {
        public static String Username;
        bool comprobant = false;

        public FormLogin()
        {
            InitializeComponent();
            Username = "";
        }

        private void ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            pictureBoxGIf.Visible = true;
            TimerLogin.Enabled = true;
            if (TextBoxName.Text.Equals("1") && TextBoxPassword.Text.Equals("2"))
            {
                comprobant = true;
            }
            else
            {
                comprobant = false;
            }
        }

        private void ButtonCheckPassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.UseSystemPasswordChar == true)
            {
                TextBoxPassword.UseSystemPasswordChar = false;
            } else if (TextBoxPassword.UseSystemPasswordChar == false)
            {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TimerLogin_Tick(object sender, EventArgs e)
        {
            TimerLogin.Stop();
            pictureBoxGIf.Visible = false;

            if (comprobant == true)
            {
                Username = TextBoxName.Text;
                this.Hide();
                MainForm frmmain = new MainForm();
                frmmain.ShowDialog();

            }
            else
            {
                LabelIncorrectLogin.Text = "Usuari i/o contrasenya incorrectes";
            }
            
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBoxPassword.Text))
            {
                ButtonCheckPassword.Visible = true;
            }
            else
            {
                ButtonCheckPassword.Visible = false;
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
