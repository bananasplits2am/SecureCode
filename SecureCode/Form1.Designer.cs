
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonMinimizeScreen = new System.Windows.Forms.Button();
            this.ButtonFullScreen = new System.Windows.Forms.Button();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelProgramTitle = new System.Windows.Forms.Label();
            this.ButtonMaximizeWindow = new System.Windows.Forms.Button();
            this.ButtonCloseApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.ButtonMinimizeScreen);
            this.TopPanel.Controls.Add(this.ButtonFullScreen);
            this.TopPanel.Controls.Add(this.LabelUserName);
            this.TopPanel.Controls.Add(this.LabelProgramTitle);
            this.TopPanel.Controls.Add(this.ButtonMaximizeWindow);
            this.TopPanel.Controls.Add(this.ButtonCloseApp);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // ButtonMinimizeScreen
            // 
            this.ButtonMinimizeScreen.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimizeScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimizeScreen.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonMinimizeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeScreen.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimizeScreen.Location = new System.Drawing.Point(900, 0);
            this.ButtonMinimizeScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimizeScreen.Name = "ButtonMinimizeScreen";
            this.ButtonMinimizeScreen.Size = new System.Drawing.Size(75, 30);
            this.ButtonMinimizeScreen.TabIndex = 5;
            this.ButtonMinimizeScreen.Text = "_";
            this.ButtonMinimizeScreen.UseMnemonic = false;
            this.ButtonMinimizeScreen.UseVisualStyleBackColor = false;
            this.ButtonMinimizeScreen.Click += new System.EventHandler(this.ButtonMinimizeScreen_Click);
            // 
            // ButtonFullScreen
            // 
            this.ButtonFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonFullScreen.FlatAppearance.BorderSize = 0;
            this.ButtonFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFullScreen.ForeColor = System.Drawing.Color.White;
            this.ButtonFullScreen.Location = new System.Drawing.Point(975, 0);
            this.ButtonFullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFullScreen.Name = "ButtonFullScreen";
            this.ButtonFullScreen.Size = new System.Drawing.Size(75, 30);
            this.ButtonFullScreen.TabIndex = 4;
            this.ButtonFullScreen.Text = "▢\t";
            this.ButtonFullScreen.UseMnemonic = false;
            this.ButtonFullScreen.UseVisualStyleBackColor = false;
            this.ButtonFullScreen.Click += new System.EventHandler(this.ButtonFullScreen_Click);
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.White;
            this.LabelUserName.Location = new System.Drawing.Point(156, 7);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(89, 16);
            this.LabelUserName.TabIndex = 3;
            this.LabelUserName.Text = "User Name Here";
            // 
            // LabelProgramTitle
            // 
            this.LabelProgramTitle.AutoSize = true;
            this.LabelProgramTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProgramTitle.ForeColor = System.Drawing.Color.White;
            this.LabelProgramTitle.Location = new System.Drawing.Point(33, 5);
            this.LabelProgramTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelProgramTitle.Name = "LabelProgramTitle";
            this.LabelProgramTitle.Size = new System.Drawing.Size(101, 18);
            this.LabelProgramTitle.TabIndex = 2;
            this.LabelProgramTitle.Text = "Secure Code";
            this.LabelProgramTitle.Click += new System.EventHandler(this.LabelProgramTitle_Click);
            // 
            // ButtonMaximizeWindow
            // 
            this.ButtonMaximizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaximizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.ButtonMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ButtonMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximizeWindow.ForeColor = System.Drawing.Color.White;
            this.ButtonMaximizeWindow.Location = new System.Drawing.Point(1050, 0);
            this.ButtonMaximizeWindow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMaximizeWindow.Name = "ButtonMaximizeWindow";
            this.ButtonMaximizeWindow.Size = new System.Drawing.Size(75, 30);
            this.ButtonMaximizeWindow.TabIndex = 1;
            this.ButtonMaximizeWindow.Text = "⛶";
            this.ButtonMaximizeWindow.UseMnemonic = false;
            this.ButtonMaximizeWindow.UseVisualStyleBackColor = false;
            this.ButtonMaximizeWindow.Click += new System.EventHandler(this.ButtonMaximizeWindow_Click);
            // 
            // ButtonCloseApp
            // 
            this.ButtonCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCloseApp.FlatAppearance.BorderSize = 0;
            this.ButtonCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ButtonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseApp.ForeColor = System.Drawing.Color.White;
            this.ButtonCloseApp.Location = new System.Drawing.Point(1125, 0);
            this.ButtonCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseApp.Name = "ButtonCloseApp";
            this.ButtonCloseApp.Size = new System.Drawing.Size(75, 30);
            this.ButtonCloseApp.TabIndex = 0;
            this.ButtonCloseApp.Text = "X";
            this.ButtonCloseApp.UseMnemonic = false;
            this.ButtonCloseApp.UseVisualStyleBackColor = false;
            this.ButtonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 532);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(4)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(5, 66);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Opció 1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(5, 124);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Opció 1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(5, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Opció 1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Button1.FlatAppearance.BorderSize = 2;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(5, 8);
            this.Button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(111, 53);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Opció 1";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SecureCode.Properties.Resources.Banana_no_background___còpia;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::SecureCode.Properties.Resources.Fons_complet_reduit;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulari";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button ButtonCloseApp;
        internal System.Windows.Forms.Button ButtonMaximizeWindow;
        private System.Windows.Forms.Label LabelProgramTitle;
        private System.Windows.Forms.Label LabelUserName;
        internal System.Windows.Forms.Button ButtonFullScreen;
        internal System.Windows.Forms.Button ButtonMinimizeScreen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
    }
}

