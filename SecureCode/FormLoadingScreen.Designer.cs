
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
            this.TimerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.LabelSplashScreen = new System.Windows.Forms.Label();
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
            this.ProgressBarSplashScreen.Location = new System.Drawing.Point(0, 309);
            this.ProgressBarSplashScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBarSplashScreen.Maximum = 101;
            this.ProgressBarSplashScreen.Name = "ProgressBarSplashScreen";
            this.ProgressBarSplashScreen.Size = new System.Drawing.Size(676, 34);
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
            this.LabelSplashScreen.Location = new System.Drawing.Point(153, 202);
            this.LabelSplashScreen.Name = "LabelSplashScreen";
            this.LabelSplashScreen.Size = new System.Drawing.Size(114, 48);
            this.LabelSplashScreen.TabIndex = 1;
            this.LabelSplashScreen.Text = "Grup 5\r\nBanana Split";
            // 
            // FormLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCode.Properties.Resources.Splash_Screen_reduced;
            this.ClientSize = new System.Drawing.Size(676, 343);
            this.Controls.Add(this.LabelSplashScreen);
            this.Controls.Add(this.ProgressBarSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerSplashScreen;
        private System.Windows.Forms.ProgressBar ProgressBarSplashScreen;
        private System.Windows.Forms.Label LabelSplashScreen;
    }
}