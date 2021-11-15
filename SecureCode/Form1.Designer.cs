
namespace SecureCode
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelUser = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.labelRango = new System.Windows.Forms.Label();
            this.labelFraseRango = new System.Windows.Forms.Label();
            this.buttonTencarSessio = new System.Windows.Forms.Button();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelAny = new System.Windows.Forms.Label();
            this.labelVersio = new System.Windows.Forms.Label();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUser
            // 
            this.LabelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.White;
            this.LabelUser.Location = new System.Drawing.Point(11, 359);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(100, 16);
            this.LabelUser.TabIndex = 3;
            this.LabelUser.Text = "Sessio Iniciada com";
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoSize = true;
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControlPanel.Controls.Add(this.labelRango);
            this.ControlPanel.Controls.Add(this.PanelButton);
            this.ControlPanel.Controls.Add(this.labelFraseRango);
            this.ControlPanel.Controls.Add(this.buttonTencarSessio);
            this.ControlPanel.Controls.Add(this.LabelUserName);
            this.ControlPanel.Controls.Add(this.pictureUser);
            this.ControlPanel.Controls.Add(this.LabelUser);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.ForeColor = System.Drawing.Color.White;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(153, 481);
            this.ControlPanel.TabIndex = 1;
            // 
            // labelRango
            // 
            this.labelRango.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRango.AutoSize = true;
            this.labelRango.Location = new System.Drawing.Point(71, 314);
            this.labelRango.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRango.Name = "labelRango";
            this.labelRango.Size = new System.Drawing.Size(36, 13);
            this.labelRango.TabIndex = 6;
            this.labelRango.Text = "*rank*";
            this.labelRango.Click += new System.EventHandler(this.labelRango_Click);
            // 
            // labelFraseRango
            // 
            this.labelFraseRango.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFraseRango.AutoSize = true;
            this.labelFraseRango.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFraseRango.ForeColor = System.Drawing.Color.White;
            this.labelFraseRango.Location = new System.Drawing.Point(7, 312);
            this.labelFraseRango.Name = "labelFraseRango";
            this.labelFraseRango.Size = new System.Drawing.Size(66, 16);
            this.labelFraseRango.TabIndex = 5;
            this.labelFraseRango.Text = "Tu rango es";
            // 
            // buttonTencarSessio
            // 
            this.buttonTencarSessio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTencarSessio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTencarSessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTencarSessio.ForeColor = System.Drawing.Color.Gray;
            this.buttonTencarSessio.Location = new System.Drawing.Point(10, 448);
            this.buttonTencarSessio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTencarSessio.Name = "buttonTencarSessio";
            this.buttonTencarSessio.Size = new System.Drawing.Size(100, 26);
            this.buttonTencarSessio.TabIndex = 3;
            this.buttonTencarSessio.Text = "Tencar sessió";
            this.buttonTencarSessio.UseVisualStyleBackColor = false;
            this.buttonTencarSessio.Click += new System.EventHandler(this.buttonTencarSessio_Click);
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(11, 378);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(35, 13);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "*user*";
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(37, 393);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(50, 49);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 4;
            this.pictureUser.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.buttonMin);
            this.panel2.Controls.Add(this.buttonInfo);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 30);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Gray;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Gray;
            this.buttonClose.Location = new System.Drawing.Point(837, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(31, 31);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.BackColor = System.Drawing.Color.Gray;
            this.buttonMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMin.BackgroundImage")));
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.ForeColor = System.Drawing.Color.Gray;
            this.buttonMin.Location = new System.Drawing.Point(805, 1);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(34, 34);
            this.buttonMin.TabIndex = 1;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.BackColor = System.Drawing.Color.Gray;
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.ForeColor = System.Drawing.Color.Gray;
            this.buttonInfo.Location = new System.Drawing.Point(775, 1);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.DarkGray;
            this.panelInfo.Controls.Add(this.labelEmpresa);
            this.panelInfo.Controls.Add(this.labelAny);
            this.panelInfo.Controls.Add(this.labelVersio);
            this.panelInfo.Location = new System.Drawing.Point(664, 30);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(203, 145);
            this.panelInfo.TabIndex = 3;
            this.panelInfo.Visible = false;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(13, 104);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(86, 15);
            this.labelEmpresa.TabIndex = 2;
            this.labelEmpresa.Text = "BananaSplit ®";
            // 
            // labelAny
            // 
            this.labelAny.AutoSize = true;
            this.labelAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAny.Location = new System.Drawing.Point(13, 64);
            this.labelAny.Name = "labelAny";
            this.labelAny.Size = new System.Drawing.Size(184, 15);
            this.labelAny.TabIndex = 1;
            this.labelAny.Text = "Data de modificació: 11/11/2021";
            // 
            // labelVersio
            // 
            this.labelVersio.AutoSize = true;
            this.labelVersio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersio.Location = new System.Drawing.Point(13, 26);
            this.labelVersio.Name = "labelVersio";
            this.labelVersio.Size = new System.Drawing.Size(71, 15);
            this.labelVersio.TabIndex = 0;
            this.labelVersio.Text = "Versió 1.0.1";
            // 
            // PanelButton
            // 
            this.PanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelButton.AutoScroll = true;
            this.PanelButton.AutoSize = true;
            this.PanelButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelButton.Location = new System.Drawing.Point(0, 30);
            this.PanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Padding = new System.Windows.Forms.Padding(5);
            this.PanelButton.Size = new System.Drawing.Size(153, 279);
            this.PanelButton.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::SecureCode.Properties.Resources.Fons;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ControlPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulari";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelAny;
        private System.Windows.Forms.Label labelVersio;
        private System.Windows.Forms.Button buttonTencarSessio;
        private System.Windows.Forms.Label labelFraseRango;
        private System.Windows.Forms.Label labelRango;
        private System.Windows.Forms.Panel PanelButton;
    }
}

