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
        ConnexioBD.ClassHederat cls = new ConnexioBD.ClassHederat();        //conectarnos a la classe ClasseConnexioBD.cs

        public MainForm()
        {
            InitializeComponent();
            LabelUser.Text = "Sessió iniciada com a";
            labelRango.Text = FormLogin.nombreRango;
            LabelUserName.Text = FormLogin.DatosUser[0];
            //this.pictureUser.Image = System.Drawing.Image.FromFile(FormLogin.photo);          //FOTO USUARI, per ara res perque tan sols funciona quan el usuari està en local
            //MessageBox.Show(acceslevel.ToString());                                           //CHECK USER ACCESS LEVEL
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
            InitializeCustomButtons(acceslevel);
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

        private void labelRango_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeCustomButtons(int acceslevel)
        {
            String consulta = "Select * From CustomControlBotons";
            int nombre_botons, atributs_botons;

            nombre_botons = cls.row_count(consulta);
            atributs_botons = cls.column_count(consulta);

            String[,] DadesBoto = new string[nombre_botons, atributs_botons];

            DadesBoto = cls.store_dts_to_array(DadesBoto);

            crear_botons_vector(DadesBoto);

            //emmagatzemar els valors en el vector
            //treure els valors en un for each
            //crear el boto
            //afegir els atributs al boto
        }

        private void crear_botons_vector(String[,] vector)
        {
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                LlencaAplicacions.SWLlenca boto_bd = new LlencaAplicacions.SWLlenca();

                //La columna 0 no s'utilitza perque es on tenim el valor emmagatzemat del ID, no ens interessa per a crear la taula
                boto_bd.Name = vector[i, 1];
                boto_bd.Titol = vector[i, 2];
                boto_bd.Rang = vector[i, 3];
                boto_bd.Form = vector[i, 4];
                boto_bd.Classe = vector[i, 5];
                //int number_color = int.Parse(vector[i, 6], System.Globalization.NumberStyles.AllowThousands);
                //boto_bd.BackColor = Color.FromArgb(number_color);        //vector[i, 6].ToString();
                //boto_bd.BackColor = Color.Red;
                boto_bd.BackColor = ColorTranslator.FromHtml(vector[i, 6]);
                //boto_bd.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                boto_bd.Height = 57;
                boto_bd.Width = 136;
                boto_bd.Margin = new Padding(3, 50, 3, 3);
                //boto_bd.Padding = new Padding(10, 0, 10, 0);
                //boto_bd.AutoSize = true;
                boto_bd.ForeColor = Color.Black;
                //boto_bd.Size = Size.Parse(vector[i, 8]);
                //boto_bd.Size = Size(Size.Parse(vector[i, 8]));
                //Int32.Parse(vector[i, 6]);

                PanelButton.Controls.Add(boto_bd);
                boto_bd.Dock = DockStyle.Top;
            }
        }
    }
}
