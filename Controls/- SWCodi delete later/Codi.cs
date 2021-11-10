using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWCodi
{
    public partial class Codi : UserControl
    {
        public Codi()
        {
            InitializeComponent();
        }

        //crear controls requerit, controlID, nivell
        //-----------------------------------------------------

        private bool _Requerit;
        public bool Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }
        }

        private String _ControlID;
        public String ControlID
        {
            get { return _ControlID; }
            set
            {
                _ControlID = value;
            }
        }

        public enum TipusDada
        {
            GM,
            GS
        }
        private TipusDada _Nivell;
        public TipusDada Nivell
        {
            get { return _Nivell; }
            set
            {
                _Nivell = value;
            }
        }

        private void ValidaCodi(object sender, CancelEventArgs e)
        {

            if ((this.Requerit == true && !TextBoxCode.Text.Equals("")) || this.Requerit == false)
            {
                if (this.Nivell.ToString().Equals("GS"))
                {
                    switch (TextBoxCode.Text)
                    {
                        case "S2AM":
                            {
                                TextBoxDescription.Text = "Desenvolupament aplicacions multiplataforma";
                                break;
                            }
                        case "S2SX":
                            {
                                TextBoxDescription.Text = "Administració de sistemes informàtics en xarxa";
                                break;
                            }
                        default:
                            {
                                TextBoxDescription.Text = "Codi incorrecte";
                                TextBoxCode.Text = null;
                                e.Cancel = false;
                                break;
                            }
                    }
                }
                else if (this.Nivell.ToString().Equals("GM"))
                {
                    switch (TextBoxCode.Text)
                    {
                        case "M2SX":
                            {
                                TextBoxDescription.Text = "Sistemes microinformàtics i xarxes";
                                break;
                            }
                        default:
                            {
                                TextBoxDescription.Text = "Codi incorrecte";
                                TextBoxCode.Text = null;
                                e.Cancel = false;
                                break;
                            }
                    }
                }
                else
                {
                    TextBoxDescription.Text = "Unknown data";
                    TextBoxCode.Text = null;
                    e.Cancel = false;
                }
            }

        }
    }
}