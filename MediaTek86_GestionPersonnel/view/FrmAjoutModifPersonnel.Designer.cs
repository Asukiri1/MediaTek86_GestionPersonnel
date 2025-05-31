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
            this.txtmail = new System.Windows.Forms.Label();
            this.txtservice = new System.Windows.Forms.Label();
            this.txtNomPersonnel = new System.Windows.Forms.TextBox();
            this.txtPrenomPersonnel = new System.Windows.Forms.TextBox();
            this.txtTelPersonnel = new System.Windows.Forms.TextBox();
            this.txtMailPersonnel = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
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
            // txtmail
            // 
            this.txtmail.AutoSize = true;
            this.txtmail.Location = new System.Drawing.Point(480, 13);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(35, 13);
            this.txtmail.TabIndex = 3;
            this.txtmail.Text = "Mail : ";
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
            // txtNomPersonnel
            // 
            this.txtNomPersonnel.Location = new System.Drawing.Point(57, 9);
            this.txtNomPersonnel.Name = "txtNomPersonnel";
            this.txtNomPersonnel.Size = new System.Drawing.Size(100, 20);
            this.txtNomPersonnel.TabIndex = 5;
            // 
            // txtPrenomPersonnel
            // 
            this.txtPrenomPersonnel.Location = new System.Drawing.Point(228, 9);
            this.txtPrenomPersonnel.Name = "txtPrenomPersonnel";
            this.txtPrenomPersonnel.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomPersonnel.TabIndex = 6;
            // 
            // txtTelPersonnel
            // 
            this.txtTelPersonnel.Location = new System.Drawing.Point(374, 9);
            this.txtTelPersonnel.Name = "txtTelPersonnel";
            this.txtTelPersonnel.Size = new System.Drawing.Size(100, 20);
            this.txtTelPersonnel.TabIndex = 7;
            // 
            // txtMailPersonnel
            // 
            this.txtMailPersonnel.Location = new System.Drawing.Point(521, 9);
            this.txtMailPersonnel.Name = "txtMailPersonnel";
            this.txtMailPersonnel.Size = new System.Drawing.Size(100, 20);
            this.txtMailPersonnel.TabIndex = 8;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(696, 8);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(100, 21);
            this.comboBoxService.TabIndex = 9;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(57, 51);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(173, 50);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 86);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.txtMailPersonnel);
            this.Controls.Add(this.txtTelPersonnel);
            this.Controls.Add(this.txtPrenomPersonnel);
            this.Controls.Add(this.txtNomPersonnel);
            this.Controls.Add(this.txtservice);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txttelperso);
            this.Controls.Add(this.txtprenomperso);
            this.Controls.Add(this.txtnomperso);
            this.Name = "FrmAjoutModifPersonnel";
            this.Text = "FrmAjoutModifPersonnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnomperso;
        private System.Windows.Forms.Label txtprenomperso;
        private System.Windows.Forms.Label txttelperso;
        private System.Windows.Forms.Label txtmail;
        private System.Windows.Forms.Label txtservice;
        private System.Windows.Forms.TextBox txtNomPersonnel;
        private System.Windows.Forms.TextBox txtPrenomPersonnel;
        private System.Windows.Forms.TextBox txtTelPersonnel;
        private System.Windows.Forms.TextBox txtMailPersonnel;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}