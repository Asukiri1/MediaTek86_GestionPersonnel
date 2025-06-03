namespace MediaTek86_GestionPersonnel.view
{
    partial class FrmGestionPersonnel
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnGererAbsences = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToOrderColumns = true;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 41);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(776, 397);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(12, 12);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "Ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.buttonAjouterPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(104, 12);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "Modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(195, 12);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "Supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnGererAbsences
            // 
            this.btnGererAbsences.Location = new System.Drawing.Point(679, 12);
            this.btnGererAbsences.Name = "btnGererAbsences";
            this.btnGererAbsences.Size = new System.Drawing.Size(109, 23);
            this.btnGererAbsences.TabIndex = 4;
            this.btnGererAbsences.Text = "Gérer les absences";
            this.btnGererAbsences.UseVisualStyleBackColor = true;
            this.btnGererAbsences.Click += new System.EventHandler(this.btnGererAbsences_Click);
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGererAbsences);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "FrmGestionPersonnel";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnGererAbsences;
    }
}