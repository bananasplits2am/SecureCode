using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LlencaAplicacions
{
    public partial class SWLlenca : UserControl
    {
        public SWLlenca()
        {
            InitializeComponent();
        }

        private String _Titol;
        public String Titol
        {
            get { return _Titol; }
            set
            {
                _Titol = value;
            }
        }

        private String _Rang;
        public String Rang
        {
            get { return _Rang; }
            set
            {
                _Rang = value;
            }
        }

        private String _Classe;
        public String Classe //namespace
        {
            get { return _Classe; }
            set
            {
                _Classe = value;
            }
        }

        private String _Form;
        public String Form //formulari a ensenyar
        {
            get { return _Form; }
            set
            {
                _Form = value;
            }
        }

        //intentar que el namespace i el nom del formulari sigui el mateix

        //--------------------------------------------------------------

        private void SWLlenca_Load(object sender, EventArgs e)
        {
            //int user = 50;
            //if (int.Parse(Rang) <= int.Parse(User)) {  //el 10 es el valor del usuari, es canviara per una variable
            Label.Text = Titol;
            //} else
            //{
            //    this.Hide();
            //}
        }

        private void SWLlenca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it activates the reflection class");
            //reflection

            Object dllBD;
            Type tipus;
            /*String codi = Classe + ".dll";

            Assembly ensamblat = Assembly.LoadFile(@codi);

            tipus = ensamblat.GetType(Classe + "." + Form);*/

            Assembly ensamblat = Assembly.LoadFrom(@"\bin\Debug\AccesDades.dll");
            tipus = ensamblat.GetType("AccessDades.Formulari");

            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }
    }
}
