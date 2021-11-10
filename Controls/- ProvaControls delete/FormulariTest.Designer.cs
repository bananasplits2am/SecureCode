
namespace ProvaControls
{
    partial class FormulariTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.swTextBox1 = new SWTextbox.SWTextBox();
            this.NameHere = new SWTextbox.SWTextBox();
            this.codi1 = new SWCodi.Codi();
            this.swLlenca1 = new LlencaAplicacions.SWLlenca();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.swTextBox1);
            this.panel1.Controls.Add(this.NameHere);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // swTextBox1
            // 
            this.swTextBox1.AllowedData = SWTextbox.SWTextBox.TipusDada.Text;
            this.swTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.swTextBox1.ControlName = "NameHere";
            this.swTextBox1.EmptyField = false;
            this.swTextBox1.ForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(15, 13);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 0;
            // 
            // NameHere
            // 
            this.NameHere.AllowedData = SWTextbox.SWTextBox.TipusDada.Text;
            this.NameHere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameHere.ControlName = "";
            this.NameHere.EmptyField = false;
            this.NameHere.ForeignKey = false;
            this.NameHere.Location = new System.Drawing.Point(15, 39);
            this.NameHere.Name = "NameHere";
            this.NameHere.Size = new System.Drawing.Size(100, 20);
            this.NameHere.TabIndex = 1;
            // 
            // codi1
            // 
            this.codi1.ControlID = null;
            this.codi1.Location = new System.Drawing.Point(58, 104);
            this.codi1.Name = "codi1";
            this.codi1.Nivell = SWCodi.Codi.TipusDada.GS;
            this.codi1.Requerit = false;
            this.codi1.Size = new System.Drawing.Size(499, 90);
            this.codi1.TabIndex = 2;
            // 
            // swLlenca1
            // 
            this.swLlenca1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.swLlenca1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.swLlenca1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.swLlenca1.Finestra_ensenyar = "Finestra nova";
            this.swLlenca1.Location = new System.Drawing.Point(342, 289);
            this.swLlenca1.Name = "swLlenca1";
            this.swLlenca1.Size = new System.Drawing.Size(193, 61);
            this.swLlenca1.TabIndex = 4;
            this.swLlenca1.Titol = "Títol de la secció";
            // 
            // FormulariTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::ProvaControls.Properties.Resources.Fons_complet_reduit;
            this.ClientSize = new System.Drawing.Size(788, 563);
            this.Controls.Add(this.swLlenca1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.codi1);
            this.Name = "FormulariTest";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SWTextbox.SWTextBox swTextBox1;
        private SWTextbox.SWTextBox NameHere;
        private SWCodi.Codi codi1;
        private System.Windows.Forms.Panel panel1;
        private LlencaAplicacions.SWLlenca swLlenca1;
    }
}

