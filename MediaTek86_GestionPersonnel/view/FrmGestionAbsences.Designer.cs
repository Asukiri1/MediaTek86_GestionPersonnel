namespace MediaTek86_GestionPersonnel.view
{
    partial class FrmGestionAbsences
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
            this.lblNomPersonnelConcerne = new System.Windows.Forms.Label();
            this.dgvAbsencesPersonnel = new System.Windows.Forms.DataGridView();
            this.buttonAddAbs = new System.Windows.Forms.Button();
            this.buttonModAbs = new System.Windows.Forms.Button();
            this.buttonDelAbs = new System.Windows.Forms.Button();
            this.btnFermerAbsences = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomPersonnelConcerne
            // 
            this.lblNomPersonnelConcerne.AutoSize = true;
            this.lblNomPersonnelConcerne.Location = new System.Drawing.Point(13, 24);
            this.lblNomPersonnelConcerne.Name = "lblNomPersonnelConcerne";
            this.lblNomPersonnelConcerne.Size = new System.Drawing.Size(35, 13);
            this.lblNomPersonnelConcerne.TabIndex = 0;
            this.lblNomPersonnelConcerne.Text = "label1";
            // 
            // dgvAbsencesPersonnel
            // 
            this.dgvAbsencesPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsencesPersonnel.Location = new System.Drawing.Point(16, 47);
            this.dgvAbsencesPersonnel.Name = "dgvAbsencesPersonnel";
            this.dgvAbsencesPersonnel.Size = new System.Drawing.Size(772, 391);
            this.dgvAbsencesPersonnel.TabIndex = 1;
            // 
            // buttonAddAbs
            // 
            this.buttonAddAbs.Location = new System.Drawing.Point(421, 19);
            this.buttonAddAbs.Name = "buttonAddAbs";
            this.buttonAddAbs.Size = new System.Drawing.Size(119, 23);
            this.buttonAddAbs.TabIndex = 2;
            this.buttonAddAbs.Text = "Ajouter absence";
            this.buttonAddAbs.UseVisualStyleBackColor = true;
            this.buttonAddAbs.Click += new System.EventHandler(this.btnAjouterAbsence_Click);
            // 
            // buttonModAbs
            // 
            this.buttonModAbs.Location = new System.Drawing.Point(546, 19);
            this.buttonModAbs.Name = "buttonModAbs";
            this.buttonModAbs.Size = new System.Drawing.Size(122, 23);
            this.buttonModAbs.TabIndex = 3;
            this.buttonModAbs.Text = "Modifier absence";
            this.buttonModAbs.UseVisualStyleBackColor = true;
            this.buttonModAbs.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // buttonDelAbs
            // 
            this.buttonDelAbs.Location = new System.Drawing.Point(674, 19);
            this.buttonDelAbs.Name = "buttonDelAbs";
            this.buttonDelAbs.Size = new System.Drawing.Size(114, 23);
            this.buttonDelAbs.TabIndex = 4;
            this.buttonDelAbs.Text = "Supprimer absence";
            this.buttonDelAbs.UseVisualStyleBackColor = true;
            // 
            // btnFermerAbsences
            // 
            this.btnFermerAbsences.Location = new System.Drawing.Point(16, 445);
            this.btnFermerAbsences.Name = "btnFermerAbsences";
            this.btnFermerAbsences.Size = new System.Drawing.Size(83, 23);
            this.btnFermerAbsences.TabIndex = 5;
            this.btnFermerAbsences.Text = "Retour";
            this.btnFermerAbsences.UseVisualStyleBackColor = true;
            // 
            // FrmGestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnFermerAbsences);
            this.Controls.Add(this.buttonDelAbs);
            this.Controls.Add(this.buttonModAbs);
            this.Controls.Add(this.buttonAddAbs);
            this.Controls.Add(this.dgvAbsencesPersonnel);
            this.Controls.Add(this.lblNomPersonnelConcerne);
            this.Name = "FrmGestionAbsences";
            this.Text = "FrmGestionAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPersonnelConcerne;
        private System.Windows.Forms.DataGridView dgvAbsencesPersonnel;
        private System.Windows.Forms.Button buttonAddAbs;
        private System.Windows.Forms.Button buttonModAbs;
        private System.Windows.Forms.Button buttonDelAbs;
        private System.Windows.Forms.Button btnFermerAbsences;
    }
}