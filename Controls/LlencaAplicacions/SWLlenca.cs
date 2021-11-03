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
    public partial class SWLlenca: UserControl
    {
        public SWLlenca()
        {
            InitializeComponent();
        }

        private String _Finestra_ensenyar;
        public String Finestra_ensenyar
        {
            get { return _Finestra_ensenyar; }
            set
            {
                _Finestra_ensenyar = value;
            }
        }

        private void SWLlenca_Load(object sender, EventArgs e)
        {
            Label.Text = Titol;
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

        private void SWLlenca_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Finestra_ensenyar);
        }
    }
}
