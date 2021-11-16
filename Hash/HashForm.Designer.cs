
namespace Hash
{
    partial class HashForm
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
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPsswd = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPsswd = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.LabelHashPsswd = new System.Windows.Forms.Label();
            this.LabelHashCode = new System.Windows.Forms.Label();
            this.TextBoxHashPsswd = new System.Windows.Forms.TextBox();
            this.TextBoxHashCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(124, 34);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // TextBoxPsswd
            // 
            this.TextBoxPsswd.Location = new System.Drawing.Point(124, 78);
            this.TextBoxPsswd.Name = "TextBoxPsswd";
            this.TextBoxPsswd.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPsswd.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(37, 37);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // LabelPsswd
            // 
            this.LabelPsswd.AutoSize = true;
            this.LabelPsswd.Location = new System.Drawing.Point(37, 81);
            this.LabelPsswd.Name = "LabelPsswd";
            this.LabelPsswd.Size = new System.Drawing.Size(53, 13);
            this.LabelPsswd.TabIndex = 3;
            this.LabelPsswd.Text = "Password";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(287, 52);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 4;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // LabelHashPsswd
            // 
            this.LabelHashPsswd.AutoSize = true;
            this.LabelHashPsswd.Location = new System.Drawing.Point(411, 81);
            this.LabelHashPsswd.Name = "LabelHashPsswd";
            this.LabelHashPsswd.Size = new System.Drawing.Size(81, 13);
            this.LabelHashPsswd.TabIndex = 9;
            this.LabelHashPsswd.Text = "Hash Password";
            // 
            // LabelHashCode
            // 
            this.LabelHashCode.AutoSize = true;
            this.LabelHashCode.Location = new System.Drawing.Point(411, 37);
            this.LabelHashCode.Name = "LabelHashCode";
            this.LabelHashCode.Size = new System.Drawing.Size(60, 13);
            this.LabelHashCode.TabIndex = 8;
            this.LabelHashCode.Text = "Hash Code";
            // 
            // TextBoxHashPsswd
            // 
            this.TextBoxHashPsswd.Location = new System.Drawing.Point(498, 78);
            this.TextBoxHashPsswd.Name = "TextBoxHashPsswd";
            this.TextBoxHashPsswd.ReadOnly = true;
            this.TextBoxHashPsswd.Size = new System.Drawing.Size(516, 20);
            this.TextBoxHashPsswd.TabIndex = 7;
            // 
            // TextBoxHashCode
            // 
            this.TextBoxHashCode.Location = new System.Drawing.Point(498, 34);
            this.TextBoxHashCode.Name = "TextBoxHashCode";
            this.TextBoxHashCode.ReadOnly = true;
            this.TextBoxHashCode.Size = new System.Drawing.Size(516, 20);
            this.TextBoxHashCode.TabIndex = 6;
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 144);
            this.Controls.Add(this.LabelHashPsswd);
            this.Controls.Add(this.LabelHashCode);
            this.Controls.Add(this.TextBoxHashPsswd);
            this.Controls.Add(this.TextBoxHashCode);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.LabelPsswd);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxPsswd);
            this.Controls.Add(this.TextBoxName);
            this.Name = "HashForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPsswd;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPsswd;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Label LabelHashPsswd;
        private System.Windows.Forms.Label LabelHashCode;
        private System.Windows.Forms.TextBox TextBoxHashPsswd;
        private System.Windows.Forms.TextBox TextBoxHashCode;
    }
}

