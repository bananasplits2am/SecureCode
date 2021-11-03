namespace SWCodi
{
    partial class Codi
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Location = new System.Drawing.Point(50, 42);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCode.TabIndex = 0;
            this.TextBoxCode.Validating += new System.ComponentModel.CancelEventHandler(this.ValidaCodi);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(187, 42);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(267, 20);
            this.TextBoxDescription.TabIndex = 1;
            // 
            // Codi
            // 
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxCode);
            this.Name = "Codi";
            this.Size = new System.Drawing.Size(536, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //mètode
        //-----------------------------------------------------

        //private void ValidaCodi(object sender, System.EventArgs e)
        //{
           
        //}


        #endregion

        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.TextBox TextBoxDescription;
    }
}
