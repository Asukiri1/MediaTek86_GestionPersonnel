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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labelpwd = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.labelpwd);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.labellogin);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(120, 75);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(11, 75);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(224, 20);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 3;
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
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(53, 20);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(8, 26);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(39, 13);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "Login :";
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
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
    }
}