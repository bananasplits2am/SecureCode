
namespace AccesDades
{
    partial class Formulari
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
            this.components = new System.ComponentModel.Container();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonActualitzar = new System.Windows.Forms.Button();
            this.ButtonVeureDataSet = new System.Windows.Forms.Button();
            this.LabelCodi = new System.Windows.Forms.Label();
            this.TextBoxCodi = new SWTextbox.SWTextBox();
            this.TextBoxDescripcio = new SWTextbox.SWTextBox();
            this.LabelDescripcio = new System.Windows.Forms.Label();
            this.RichTextBoxXML = new System.Windows.Forms.RichTextBox();
            this.ButtonNou = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdBannanaSplitDataSet = new AccesDades.bdBannanaSplitDataSet();
            this.bdBannanaSplitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBannanaSplitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBannanaSplitDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(61, 111);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(659, 134);
            this.DataGridView.TabIndex = 0;
            // 
            // ButtonActualitzar
            // 
            this.ButtonActualitzar.Location = new System.Drawing.Point(476, 251);
            this.ButtonActualitzar.Name = "ButtonActualitzar";
            this.ButtonActualitzar.Size = new System.Drawing.Size(119, 23);
            this.ButtonActualitzar.TabIndex = 1;
            this.ButtonActualitzar.Text = "Actualitzar";
            this.ButtonActualitzar.UseVisualStyleBackColor = true;
            this.ButtonActualitzar.Click += new System.EventHandler(this.ButtonActualitzar_Click);
            // 
            // ButtonVeureDataSet
            // 
            this.ButtonVeureDataSet.Location = new System.Drawing.Point(601, 251);
            this.ButtonVeureDataSet.Name = "ButtonVeureDataSet";
            this.ButtonVeureDataSet.Size = new System.Drawing.Size(119, 23);
            this.ButtonVeureDataSet.TabIndex = 2;
            this.ButtonVeureDataSet.Text = "Veure DataSet";
            this.ButtonVeureDataSet.UseVisualStyleBackColor = true;
            this.ButtonVeureDataSet.Click += new System.EventHandler(this.ButtonVeureDataSet_Click);
            // 
            // LabelCodi
            // 
            this.LabelCodi.AutoSize = true;
            this.LabelCodi.Location = new System.Drawing.Point(58, 30);
            this.LabelCodi.Name = "LabelCodi";
            this.LabelCodi.Size = new System.Drawing.Size(31, 13);
            this.LabelCodi.TabIndex = 3;
            this.LabelCodi.Text = "Codi:";
            // 
            // TextBoxCodi
            // 
            this.TextBoxCodi.AllowedData = SWTextbox.SWTextBox.TipusDada.Text;
            this.TextBoxCodi.ControlName = null;
            this.TextBoxCodi.ForeignKey = false;
            this.TextBoxCodi.Location = new System.Drawing.Point(12, 15);
            this.TextBoxCodi.Name = "TextBoxCodi";
            this.TextBoxCodi.Size = new System.Drawing.Size(282, 20);
            this.TextBoxCodi.TabIndex = 6;
            // 
            // TextBoxDescripcio
            // 
            this.TextBoxDescripcio.AllowedData = SWTextbox.SWTextBox.TipusDada.Text;
            this.TextBoxDescripcio.ControlName = null;
            this.TextBoxDescripcio.ForeignKey = false;
            this.TextBoxDescripcio.Location = new System.Drawing.Point(12, 48);
            this.TextBoxDescripcio.Name = "TextBoxDescripcio";
            this.TextBoxDescripcio.Size = new System.Drawing.Size(282, 20);
            this.TextBoxDescripcio.TabIndex = 7;
            // 
            // LabelDescripcio
            // 
            this.LabelDescripcio.AutoSize = true;
            this.LabelDescripcio.Location = new System.Drawing.Point(58, 63);
            this.LabelDescripcio.Name = "LabelDescripcio";
            this.LabelDescripcio.Size = new System.Drawing.Size(60, 13);
            this.LabelDescripcio.TabIndex = 8;
            this.LabelDescripcio.Text = "Descripció:";
            // 
            // RichTextBoxXML
            // 
            this.RichTextBoxXML.Location = new System.Drawing.Point(61, 280);
            this.RichTextBoxXML.Name = "RichTextBoxXML";
            this.RichTextBoxXML.Size = new System.Drawing.Size(659, 134);
            this.RichTextBoxXML.TabIndex = 10;
            this.RichTextBoxXML.Text = "";
            // 
            // ButtonNou
            // 
            this.ButtonNou.Location = new System.Drawing.Point(351, 251);
            this.ButtonNou.Name = "ButtonNou";
            this.ButtonNou.Size = new System.Drawing.Size(119, 23);
            this.ButtonNou.TabIndex = 11;
            this.ButtonNou.Text = "Nou";
            this.ButtonNou.UseVisualStyleBackColor = true;
            this.ButtonNou.Click += new System.EventHandler(this.ButtonNou_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBoxCodi);
            this.panel1.Controls.Add(this.TextBoxDescripcio);
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 83);
            this.panel1.TabIndex = 12;
            // 
            // bdBannanaSplitDataSet
            // 
            this.bdBannanaSplitDataSet.DataSetName = "bdBannanaSplitDataSet";
            this.bdBannanaSplitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdBannanaSplitDataSetBindingSource
            // 
            this.bdBannanaSplitDataSetBindingSource.DataSource = this.bdBannanaSplitDataSet;
            this.bdBannanaSplitDataSetBindingSource.Position = 0;
            // 
            // Formulari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNou);
            this.Controls.Add(this.RichTextBoxXML);
            this.Controls.Add(this.LabelDescripcio);
            this.Controls.Add(this.LabelCodi);
            this.Controls.Add(this.ButtonVeureDataSet);
            this.Controls.Add(this.ButtonActualitzar);
            this.Controls.Add(this.DataGridView);
            this.Name = "Formulari";
            this.Text = "hello everyone";
            this.Load += new System.EventHandler(this.Formulari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdBannanaSplitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBannanaSplitDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ButtonActualitzar;
        private System.Windows.Forms.Button ButtonVeureDataSet;
        private System.Windows.Forms.Label LabelCodi;
        private SWTextbox.SWTextBox TextBoxCodi;
        private SWTextbox.SWTextBox TextBoxDescripcio;
        private System.Windows.Forms.Label LabelDescripcio;
        private System.Windows.Forms.RichTextBox RichTextBoxXML;
        private System.Windows.Forms.Button ButtonNou;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdBannanaSplitDataSetBindingSource;
        private bdBannanaSplitDataSet bdBannanaSplitDataSet;
    }
}

