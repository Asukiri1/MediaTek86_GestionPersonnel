namespace MediaTek86_GestionPersonnel.view
{
    partial class FrmAjoutModifAbsence
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de début : ";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(103, 12);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de fin : ";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(387, 12);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 3;
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(57, 68);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(121, 21);
            this.cmbMotif.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Motif : ";
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(16, 118);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerAbsence.TabIndex = 6;
            this.btnEnregistrerAbsence.Text = "Enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbsence.Click += new System.EventHandler(this.btnEnregistrerAbsence_Click);
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(107, 117);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerAbsence.TabIndex = 7;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAbsence.Click += new System.EventHandler(this.btnAnnulerAbsence_Click);
            // 
            // FrmAjoutModifAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 160);
            this.Controls.Add(this.btnAnnulerAbsence);
            this.Controls.Add(this.btnEnregistrerAbsence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMotif);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutModifAbsence";
            this.Text = "FrmAjoutModifAbsence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Button btnAnnulerAbsence;
    }
}