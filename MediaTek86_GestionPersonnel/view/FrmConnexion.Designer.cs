namespace MediaTek86_GestionPersonnel.view
{
    partial class FrmConnexion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.labelpwd = new System.Windows.Forms.Label();
            this.textpwd = new System.Windows.Forms.TextBox();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnquitter);
            this.groupBox1.Controls.Add(this.btnvalider);
            this.groupBox1.Controls.Add(this.textpwd);
            this.groupBox1.Controls.Add(this.labelpwd);
            this.groupBox1.Controls.Add(this.textlogin);
            this.groupBox1.Controls.Add(this.labellogin);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(8, 26);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(39, 13);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Login :";
            this.labellogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(53, 20);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(100, 20);
            this.textlogin.TabIndex = 1;
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.Location = new System.Drawing.Point(186, 26);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(34, 13);
            this.labelpwd.TabIndex = 2;
            this.labelpwd.Text = "Pwd :";
            // 
            // textpwd
            // 
            this.textpwd.Location = new System.Drawing.Point(224, 20);
            this.textpwd.Name = "textpwd";
            this.textpwd.PasswordChar = '*';
            this.textpwd.Size = new System.Drawing.Size(100, 20);
            this.textpwd.TabIndex = 3;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(11, 75);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(100, 23);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(120, 75);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(100, 23);
            this.btnquitter.TabIndex = 5;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 128);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.TextBox textpwd;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnvalider;
    }
}