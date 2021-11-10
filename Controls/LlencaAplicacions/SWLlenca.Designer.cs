using System;
using System.Reflection;
using System.Windows.Forms;

namespace LlencaAplicacions
{
    partial class SWLlenca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Random rnd = new Random();

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LlencaAplicacions.Properties.Resources.Banana_no_background___còpia;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(39, 23);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(68, 16);
            this.Label.TabIndex = 1;
            this.Label.Text = "Accés a X";
            // 
            // SWLlenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SWLlenca";
            this.Size = new System.Drawing.Size(136, 57);
            this.Load += new System.EventHandler(this.SWLlenca_Load);
            this.Click += new System.EventHandler(this.SWLlenca_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private Label Label;

        #endregion

        //using system.reflection
        //----write here

        //Assembly AssemLlenca = Assembly.LoadFile(@"LlencaAplicacions.dll");

        //Type tipus = AssemLlenca.GetType("LlencaAplicacions.SWLlenca");

        //Type tipus = Assembly.LoadFile(@"LlencaAplicacions.dll").GetType("LlencaAplicacions.SWLlenca");

        //Object dllBD = Activator.CreateInstance(tipus);


        //Object dllBD = Activator.CreateInstance(Assembly.LoadFile(@"LlencaAplicacions.dll").GetType("LlencaAplicacions.SWLlenca"));
        //((Form)dllBD).Show();


    }
}
