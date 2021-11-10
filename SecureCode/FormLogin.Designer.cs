
namespace SecureCode
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelLoginWelcome = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelLoginTop = new System.Windows.Forms.Panel();
            this.ButtonCloseApp = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelIncorrectLogin = new System.Windows.Forms.Label();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.ButtonCheckPassword = new System.Windows.Forms.Button();
            this.PanelGeneralInformation = new System.Windows.Forms.Panel();
            this.LabelWelcomeText = new System.Windows.Forms.Label();
            this.TimerLogin = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGIf = new System.Windows.Forms.PictureBox();
            this.PanelLoginTop.SuspendLayout();
            this.PanelGeneralInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIf)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AllowDrop = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(80, 45);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(166, 57);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login";
            // 
            // LabelLoginWelcome
            // 
            this.LabelLoginWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoginWelcome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginWelcome.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelLoginWelcome.Location = new System.Drawing.Point(81, 102);
            this.LabelLoginWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLoginWelcome.Name = "LabelLoginWelcome";
            this.LabelLoginWelcome.Size = new System.Drawing.Size(344, 35);
            this.LabelLoginWelcome.TabIndex = 0;
            this.LabelLoginWelcome.Text = "Benvingut al Secure Code";
            // 
            // LabelName
            // 
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.Location = new System.Drawing.Point(84, 202);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(86, 35);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nom";
            // 
            // PanelLoginTop
            // 
            this.PanelLoginTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelLoginTop.Controls.Add(this.ButtonCloseApp);
            this.PanelLoginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLoginTop.Location = new System.Drawing.Point(0, 0);
            this.PanelLoginTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelLoginTop.Name = "PanelLoginTop";
            this.PanelLoginTop.Size = new System.Drawing.Size(600, 46);
            this.PanelLoginTop.TabIndex = 1;
            this.PanelLoginTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLoginTop_MouseDown);
            this.PanelLoginTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelLoginTop_MouseMove);
            this.PanelLoginTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelLoginTop_MouseUp);
            // 
            // ButtonCloseApp
            // 
            this.ButtonCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCloseApp.FlatAppearance.BorderSize = 0;
            this.ButtonCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ButtonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseApp.ForeColor = System.Drawing.Color.White;
            this.ButtonCloseApp.Location = new System.Drawing.Point(488, 0);
            this.ButtonCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseApp.Name = "ButtonCloseApp";
            this.ButtonCloseApp.Size = new System.Drawing.Size(112, 46);
            this.ButtonCloseApp.TabIndex = 1;
            this.ButtonCloseApp.Text = "X";
            this.ButtonCloseApp.UseMnemonic = false;
            this.ButtonCloseApp.UseVisualStyleBackColor = false;
            this.ButtonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.AcceptsReturn = true;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(87, 242);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(413, 35);
            this.TextBoxName.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(87, 354);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(412, 35);
            this.TextBoxPassword.TabIndex = 5;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // LabelPassword
            // 
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelPassword.Location = new System.Drawing.Point(84, 314);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(201, 35);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Contrasenya";
            // 
            // LabelIncorrectLogin
            // 
            this.LabelIncorrectLogin.AutoSize = true;
            this.LabelIncorrectLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.LabelIncorrectLogin.Location = new System.Drawing.Point(190, 469);
            this.LabelIncorrectLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIncorrectLogin.Name = "LabelIncorrectLogin";
            this.LabelIncorrectLogin.Size = new System.Drawing.Size(0, 20);
            this.LabelIncorrectLogin.TabIndex = 6;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.BackColor = System.Drawing.Color.Red;
            this.ButtonLogIn.FlatAppearance.BorderSize = 0;
            this.ButtonLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ButtonLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.ButtonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogIn.Location = new System.Drawing.Point(208, 485);
            this.ButtonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(200, 40);
            this.ButtonLogIn.TabIndex = 7;
            this.ButtonLogIn.Text = "Accedir";
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // ButtonCheckPassword
            // 
            this.ButtonCheckPassword.BackColor = System.Drawing.Color.Red;
            this.ButtonCheckPassword.FlatAppearance.BorderSize = 0;
            this.ButtonCheckPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ButtonCheckPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.ButtonCheckPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckPassword.Location = new System.Drawing.Point(458, 359);
            this.ButtonCheckPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCheckPassword.Name = "ButtonCheckPassword";
            this.ButtonCheckPassword.Size = new System.Drawing.Size(37, 29);
            this.ButtonCheckPassword.TabIndex = 8;
            this.ButtonCheckPassword.Text = "👁 ";
            this.ButtonCheckPassword.UseVisualStyleBackColor = false;
            this.ButtonCheckPassword.Visible = false;
            this.ButtonCheckPassword.Click += new System.EventHandler(this.ButtonCheckPassword_Click);
            // 
            // PanelGeneralInformation
            // 
            this.PanelGeneralInformation.BackColor = System.Drawing.Color.Transparent;
            this.PanelGeneralInformation.Controls.Add(this.ButtonLogIn);
            this.PanelGeneralInformation.Controls.Add(this.ButtonCheckPassword);
            this.PanelGeneralInformation.Controls.Add(this.LabelLogin);
            this.PanelGeneralInformation.Controls.Add(this.LabelLoginWelcome);
            this.PanelGeneralInformation.Controls.Add(this.TextBoxPassword);
            this.PanelGeneralInformation.Controls.Add(this.LabelName);
            this.PanelGeneralInformation.Controls.Add(this.LabelPassword);
            this.PanelGeneralInformation.Controls.Add(this.TextBoxName);
            this.PanelGeneralInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGeneralInformation.Location = new System.Drawing.Point(0, 46);
            this.PanelGeneralInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelGeneralInformation.Name = "PanelGeneralInformation";
            this.PanelGeneralInformation.Size = new System.Drawing.Size(600, 529);
            this.PanelGeneralInformation.TabIndex = 9;
            // 
            // LabelWelcomeText
            // 
            this.LabelWelcomeText.AutoSize = true;
            this.LabelWelcomeText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeText.ForeColor = System.Drawing.Color.White;
            this.LabelWelcomeText.Location = new System.Drawing.Point(82, 598);
            this.LabelWelcomeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWelcomeText.Name = "LabelWelcomeText";
            this.LabelWelcomeText.Size = new System.Drawing.Size(0, 28);
            this.LabelWelcomeText.TabIndex = 10;
            this.LabelWelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLogin
            // 
            this.TimerLogin.Interval = 6000;
            this.TimerLogin.Tick += new System.EventHandler(this.TimerLogin_Tick);
            // 
            // pictureBoxGIf
            // 
            this.pictureBoxGIf.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGIf.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGIf.Image")));
            this.pictureBoxGIf.Location = new System.Drawing.Point(208, 583);
            this.pictureBoxGIf.Name = "pictureBoxGIf";
            this.pictureBoxGIf.Size = new System.Drawing.Size(181, 92);
            this.pictureBoxGIf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGIf.TabIndex = 11;
            this.pictureBoxGIf.TabStop = false;
            this.pictureBoxGIf.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.BackgroundImage = global::SecureCode.Properties.Resources.Fons_Reduit;
            this.ClientSize = new System.Drawing.Size(600, 760);
            this.Controls.Add(this.pictureBoxGIf);
            this.Controls.Add(this.LabelWelcomeText);
            this.Controls.Add(this.LabelIncorrectLogin);
            this.Controls.Add(this.PanelGeneralInformation);
            this.Controls.Add(this.PanelLoginTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PanelLoginTop.ResumeLayout(false);
            this.PanelGeneralInformation.ResumeLayout(false);
            this.PanelGeneralInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelLoginWelcome;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel PanelLoginTop;
        internal System.Windows.Forms.Button ButtonCloseApp;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelIncorrectLogin;
        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.Button ButtonCheckPassword;
        private System.Windows.Forms.Panel PanelGeneralInformation;
        private System.Windows.Forms.Label LabelWelcomeText;
        private System.Windows.Forms.Timer TimerLogin;
        private System.Windows.Forms.PictureBox pictureBoxGIf;
    }
}