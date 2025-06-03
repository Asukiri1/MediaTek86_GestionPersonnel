using MediaTek86_GestionPersonnel.controller;
using MediaTek86_GestionPersonnel.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MediaTek86_GestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion des absences pour un personnel donné.
    /// Permet d'afficher, ajouter, modifier et supprimer des absences.
    /// </summary>
    public partial class FrmGestionAbsences : Form
    {
        private readonly FrmGestionAbsencesController controller;
        private readonly Personnel personnelConcerne; 
        private BindingSource bsAbsences;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="personnel">Le personnel pour lequel afficher les absences.</param>
        public FrmGestionAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.controller = new FrmGestionAbsencesController();
            this.personnelConcerne = personnel;
            this.bsAbsences = new BindingSource();

            // Afficher le nom du personnel
            if (lblNomPersonnelConcerne != null)
            {
                lblNomPersonnelConcerne.Text = "Absences de : " + personnelConcerne.Prenom + " " + personnelConcerne.Nom;
            }
            this.Text = "Gestion des absences de " + personnelConcerne.Prenom + " " + personnelConcerne.Nom;


            // Lier le DataGridView au BindingSource
            if (dgvAbsencesPersonnel != null)
            {
                dgvAbsencesPersonnel.DataSource = bsAbsences;
                ConfigurerDataGridViewAbsences();
                ChargerAbsences();
            }
            else
            {
                MessageBox.Show("Le contrôle DataGridView 'dgvAbsencesPersonnel' n'a pas été trouvé.", "Erreur UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configure l'apparence et les colonnes du DataGridView des absences.
        /// </summary>
        private void ConfigurerDataGridViewAbsences()
        {
            if (dgvAbsencesPersonnel == null) return;

            dgvAbsencesPersonnel.AutoGenerateColumns = false;
            dgvAbsencesPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dgvAbsencesPersonnel.AllowUserToAddRows = false;
            dgvAbsencesPersonnel.AllowUserToDeleteRows = false;
            dgvAbsencesPersonnel.ReadOnly = true;
            dgvAbsencesPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAbsencesPersonnel.Columns.Clear();

            // Définir les colonnes
            DataGridViewTextBoxColumn colDateDebut = new DataGridViewTextBoxColumn();
            colDateDebut.DataPropertyName = "DateDebut";
            colDateDebut.HeaderText = "Date de début";
            colDateDebut.Name = "colDateDebut";
            colDateDebut.DefaultCellStyle.Format = "dd/MM/yyyy"; 

            DataGridViewTextBoxColumn colDateFin = new DataGridViewTextBoxColumn();
            colDateFin.DataPropertyName = "DateFin";
            colDateFin.HeaderText = "Date de fin";
            colDateFin.Name = "colDateFin";
            colDateFin.DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colMotif = new DataGridViewTextBoxColumn();
            colMotif.DataPropertyName = "MotifLibelle"; 
            colMotif.HeaderText = "Motif";
            colMotif.Name = "colMotif";

            DataGridViewTextBoxColumn colIdPersonnel = new DataGridViewTextBoxColumn();
            colIdPersonnel.DataPropertyName = "IdPersonnel";
            colIdPersonnel.Visible = false;
            colIdPersonnel.Name = "colIdPersonnelAbs";


            DataGridViewTextBoxColumn colIdMotif = new DataGridViewTextBoxColumn();
            colIdMotif.DataPropertyName = "IdMotif";
            colIdMotif.Visible = false;
            colIdMotif.Name = "colIdMotifAbs";


            dgvAbsencesPersonnel.Columns.AddRange(new DataGridViewColumn[] { colDateDebut, colDateFin, colMotif, colIdPersonnel, colIdMotif });
        }

        /// <summary>
        /// Charge ou met à jour la liste des absences pour le personnel concerné.
        /// </summary>
        public void ChargerAbsences()
        {
            if (personnelConcerne != null)
            {
                List<Absence> lesAbsences = controller.GetLesAbsences(personnelConcerne.IdPersonnel);
                bsAbsences.DataSource = lesAbsences;
            }
        }

        private void btnFermerAbsences_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAjouterAbsence_Click(object sender, EventArgs e)
        {

            FrmAjoutModifAbsence frmAjout = new FrmAjoutModifAbsence(this.controller, this.personnelConcerne);
            DialogResult resultat = frmAjout.ShowDialog(this);

            if (resultat == DialogResult.OK)
            {
                ChargerAbsences();
            }
        }
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsencesPersonnel.SelectedRows.Count > 0)
            {
                Absence absenceSelectionnee = (Absence)bsAbsences.Current;

                if (absenceSelectionnee != null)
                {
                    FrmAjoutModifAbsence frmModif = new FrmAjoutModifAbsence(this.controller, this.personnelConcerne, absenceSelectionnee);
                    DialogResult resultat = frmModif.ShowDialog(this);

                    if (resultat == DialogResult.OK)
                    {
                        ChargerAbsences();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsencesPersonnel.SelectedRows.Count > 0)
            {
                Absence absenceSelectionnee = (Absence)bsAbsences.Current;

                if (absenceSelectionnee != null)
                {
                    // Demander confirmation à l'utilisateur
                    DialogResult confirmation = MessageBox.Show(
                        $"Êtes-vous sûr de vouloir supprimer l'absence du {absenceSelectionnee.DateDebut:dd/MM/yyyy} au {absenceSelectionnee.DateFin:dd/MM/yyyy} pour le motif '{absenceSelectionnee.MotifLibelle}' ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmation == DialogResult.Yes)
                    {

                        if (controller.SupprimerAbsence(absenceSelectionnee.IdPersonnel, absenceSelectionnee.DateDebut))
                        {
                            MessageBox.Show("Absence supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChargerAbsences(); 
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression de l'absence.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

