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
            Label.Text = Titol;
        }

        private void SWLlenca_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Form);
            //reflection

            Object dllBD;
            Type tipus;

            Assembly ensamblat = Assembly.LoadFile(@"" + Classe + ".exe");

            tipus = ensamblat.GetType(Classe + "." + Form);

            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
        }
    }
}
