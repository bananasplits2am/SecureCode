
namespace SecureCode
{
    partial class FormLoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadingScreen));
            this.TimerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.LabelSplashScreen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerSplashScreen
            // 
            this.TimerSplashScreen.Enabled = true;
            this.TimerSplashScreen.Interval = 40;
            this.TimerSplashScreen.Tick += new System.EventHandler(this.TimerSplashScreen_Tick);
            // 
            // ProgressBarSplashScreen
            // 
            this.ProgressBarSplashScreen.BackColor = System.Drawing.Color.Black;
            this.ProgressBarSplashScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarSplashScreen.ForeColor = System.Drawing.Color.Transparent;
            this.ProgressBarSplashScreen.Location = new System.Drawing.Point(0, 498);
            this.ProgressBarSplashScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBarSplashScreen.Maximum = 101;
            this.ProgressBarSplashScreen.Name = "ProgressBarSplashScreen";
            this.ProgressBarSplashScreen.Size = new System.Drawing.Size(1000, 52);
            this.ProgressBarSplashScreen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarSplashScreen.TabIndex = 0;
            this.ProgressBarSplashScreen.Click += new System.EventHandler(this.ProgressBarSplashScreen_Click);
            // 
            // LabelSplashScreen
            // 
            this.LabelSplashScreen.AutoSize = true;
            this.LabelSplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.LabelSplashScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSplashScreen.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSplashScreen.Location = new System.Drawing.Point(230, 311);
            this.LabelSplashScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSplashScreen.Name = "LabelSplashScreen";
            this.LabelSplashScreen.Size = new System.Drawing.Size(179, 66);
            this.LabelSplashScreen.TabIndex = 1;
            this.LabelSplashScreen.Text = "Grup 5\r\nBanana Split";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCode.Properties.Resources.Splash_Screen_reduced;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelSplashScreen);
            this.Controls.Add(this.ProgressBarSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerSplashScreen;
        private System.Windows.Forms.ProgressBar ProgressBarSplashScreen;
        private System.Windows.Forms.Label LabelSplashScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}