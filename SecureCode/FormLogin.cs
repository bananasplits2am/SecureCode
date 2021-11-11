using System;
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
        public static String[] DatosUser;
        public static String nombreRango, photo;
        public static int acceslevel;
        private bool arrastrar = false;
        private Point posicionInicio = new Point(0, 0);
        bool comprobant = false;
        ConnexioBD.ClassHederat cls = new ConnexioBD.ClassHederat();

        public FormLogin()
        {
            InitializeComponent();
            //Username[0] = "";
        }

        private void ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            pictureBoxGIf.Visible = true;
            TimerLogin.Enabled = true;

            comprobant = ComprbarUsuari();
            //AQUI LES FUNCIONS DE CLASS1
            //TextBoxName.Text.Equals("1") && TextBoxPassword.Text.Equals("2")

        }

        private bool ComprbarUsuari()
        {
            //String Name = TextBoxName.Text;
            //TextBoxName.Text.Equals("1") && TextBoxPassword.Text.Equals("2")
            String consulta = "Select Login, Password From users Where Login like ('" + TextBoxName.Text.Trim() + "') and Password like ('" + TextBoxPassword.Text + "')";

            cls.PortarperConsulta(consulta);

            return cls.comprobar_psswd(TextBoxName.Text.Trim(), TextBoxPassword.Text);
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
                DatosUser = cls.DatosUsuario(TextBoxName.Text.Trim());
                nombreRango = cls.RangoUsuarioNombre(DatosUser[2]);
                acceslevel = cls.CategoriaUsuariNumero(DatosUser[1]);
                photo = cls.FotoUsuario(TextBoxName.Text.Trim());
                this.Hide();
                MainForm frmmain = new MainForm();
                frmmain.ShowDialog();

            }
            else
            {
                LabelIncorrectLogin.ForeColor = Color.Red;
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LabelIncorrectLogin.ForeColor = Color.White;
            LabelIncorrectLogin.Text = "Benvingut a BananSplit";
        }

        private void PanelLoginTop_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            posicionInicio = new Point(e.X, e.Y);
        }

        private void PanelLoginTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrar)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.posicionInicio.X, p.Y - this.posicionInicio.Y);
            }
        }

        private void PanelLoginTop_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                pictureBoxGIf.Visible = true;
                TimerLogin.Enabled = true;

                comprobant = ComprbarUsuari();
            }
        }
    }
}
