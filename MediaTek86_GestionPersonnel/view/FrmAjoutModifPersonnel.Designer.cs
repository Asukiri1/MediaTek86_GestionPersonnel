namespace MediaTek86_GestionPersonnel.view
{
    partial class FrmAjoutModifPersonnel
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
            this.txtnomperso = new System.Windows.Forms.Label();
            this.txtprenomperso = new System.Windows.Forms.Label();
            this.txttelperso = new System.Windows.Forms.Label();
            this.txtMaillabel = new System.Windows.Forms.Label();
            this.txtservice = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnomperso
            // 
            this.txtnomperso.AutoSize = true;
            this.txtnomperso.Location = new System.Drawing.Point(13, 13);
            this.txtnomperso.Name = "txtnomperso";
            this.txtnomperso.Size = new System.Drawing.Size(38, 13);
            this.txtnomperso.TabIndex = 0;
            this.txtnomperso.Text = "Nom : ";
            // 
            // txtprenomperso
            // 
            this.txtprenomperso.AutoSize = true;
            this.txtprenomperso.Location = new System.Drawing.Point(170, 13);
            this.txtprenomperso.Name = "txtprenomperso";
            this.txtprenomperso.Size = new System.Drawing.Size(52, 13);
            this.txtprenomperso.TabIndex = 1;
            this.txtprenomperso.Text = "Prenom : ";
            // 
            // txttelperso
            // 
            this.txttelperso.AutoSize = true;
            this.txttelperso.Location = new System.Drawing.Point(337, 13);
            this.txttelperso.Name = "txttelperso";
            this.txttelperso.Size = new System.Drawing.Size(31, 13);
            this.txttelperso.TabIndex = 2;
            this.txttelperso.Text = "Tel : ";
            // 
            // txtMaillabel
            // 
            this.txtMaillabel.AutoSize = true;
            this.txtMaillabel.Location = new System.Drawing.Point(480, 13);
            this.txtMaillabel.Name = "txtMaillabel";
            this.txtMaillabel.Size = new System.Drawing.Size(35, 13);
            this.txtMaillabel.TabIndex = 3;
            this.txtMaillabel.Text = "Mail : ";
            // 
            // txtservice
            // 
            this.txtservice.AutoSize = true;
            this.txtservice.Location = new System.Drawing.Point(638, 12);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(52, 13);
            this.txtservice.TabIndex = 4;
            this.txtservice.Text = "Service : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(57, 9);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(228, 9);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(374, 9);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(521, 9);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 8;
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(696, 8);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(100, 21);
            this.cmbService.TabIndex = 9;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(57, 51);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(173, 50);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmAjoutModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 86);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtservice);
            this.Controls.Add(this.txtMaillabel);
            this.Controls.Add(this.txttelperso);
            this.Controls.Add(this.txtprenomperso);
            this.Controls.Add(this.txtnomperso);
            this.Name = "FrmAjoutModifPersonnel";
            this.Text = "Ajout et modification du personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnomperso;
        private System.Windows.Forms.Label txtprenomperso;
        private System.Windows.Forms.Label txttelperso;
        private System.Windows.Forms.Label txtMaillabel;
        private System.Windows.Forms.Label txtservice;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}