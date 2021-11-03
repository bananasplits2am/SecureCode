using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //per poder fer la referencia
using System.Drawing;       //canviar paràmetres com els colors
using System.Text.RegularExpressions;   //per utilitzar el regex

namespace SWTextbox
{
    public class SWTextBox : TextBox
    {
        //escollir propietat
        //-----------------------------------------------------

        public SWTextBox ()
        {
            InitializeComponent();
        }

        public enum TipusDada
        {
            Text,
            Numero,
            Codi,
            Data
        }

        private TipusDada _AllowedData;
        public TipusDada AllowedData
        {
            get { return _AllowedData; }
            set
            {
                _AllowedData = value;
            }
        }

        //canviar focus color
        //-----------------------------------------------------

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enter += new System.EventHandler(this.SWTextBox_Enter);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextBox_Validating);
            this.ResumeLayout(false);

        }

        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void SWTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 192, 1);
        }

        //si podem abandonar o no segons si el camp està ple o buit
        //-----------------------------------------------------

        public void SWTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool comprobant;

            //validar dades es corresponguin amb la propietat anterior
            //-----------------------------------------------------

            String patro = "", variable = this.AllowedData.ToString();

            switch (variable)
            {
                case "Text":
                    {
                        patro = ""; //qualsevol tipus de text és acceptat
                        break;
                    }
                case "Numero":
                    {
                        patro = @"^\d$"; //accepta tan sols un úmero
                        break;
                    }
                case "Codi":
                    {
                        patro = @"^[A-Za-z]{4}\-\d{3}\/\d[AEIOUaeiou]$"; //accepta un codi format per dos lletres i dos nombres
                        break;
                    }
                case "Data":
                    {
                        patro = @"^\d{1,2}\-\d{1,2}\-\d{4}$"; //accepta el format data XX-YY-ZZZ, amb els valors X i Y poden ser tan sols un
                        break;
                    }
            }

            Regex rgx = new Regex(patro);

            if (EmptyField == false && !String.IsNullOrEmpty(this.Text) && rgx.IsMatch(this.Text))
            {
                comprobant = true;
                if (ForeignKey == true)
                {
                    foreach (TextBox item in this.Parent.Controls)
                    {
                        if(this.ControlName == item.Name)
                        {
                            item.Text = this.Text;
                        }
                    }
                }
            } else if (EmptyField == true)
            {
                comprobant = true;
            } else
            {
                comprobant = false;
            }

            //-----------------------------------------------------
            //END - validar dades es corresponguin amb la propietat anterior

            e.Cancel = !comprobant;
        }

        //bool que comproba si es foranea
        //-----------------------------------------------------

        private bool _ForeignKey;
        public bool ForeignKey
        {
            get { return _ForeignKey; }
            set
            {
                _ForeignKey = value;
            }
        }

        private bool _EmptyField;
        public bool EmptyField
        {
            get { return _EmptyField; }
            set
            {
                _EmptyField = value;
            }
        }


        //string nom del control
        //-----------------------------------------------------

        private string _ControlName;
        public string ControlName
        {
            get { return _ControlName; }
            set
            {
                _ControlName = value;
            }
        }

    }
}
