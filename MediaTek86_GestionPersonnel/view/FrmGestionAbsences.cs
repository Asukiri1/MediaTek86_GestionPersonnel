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
    public partial class FrmGestionAbsences : Form
    {
        private readonly FrmGestionAbsencesController controller;
        private readonly Personnel personnelConcerne; // Le personnel dont on gère les absences
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
            // Assure-toi que ton Label s'appelle lblNomPersonnelConcerne
            if (lblNomPersonnelConcerne != null)
            {
                lblNomPersonnelConcerne.Text = "Absences de : " + personnelConcerne.Prenom + " " + personnelConcerne.Nom;
            }
            this.Text = "Gestion des absences de " + personnelConcerne.Prenom + " " + personnelConcerne.Nom;


            // Lier le DataGridView au BindingSource
            // Assure-toi que ton DataGridView s'appelle dgvAbsencesPersonnel
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
            dgvAbsencesPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ou AllCells
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
            colDateDebut.DefaultCellStyle.Format = "dd/MM/yyyy"; // Format de date court

            DataGridViewTextBoxColumn colDateFin = new DataGridViewTextBoxColumn();
            colDateFin.DataPropertyName = "DateFin";
            colDateFin.HeaderText = "Date de fin";
            colDateFin.Name = "colDateFin";
            colDateFin.DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colMotif = new DataGridViewTextBoxColumn();
            colMotif.DataPropertyName = "MotifLibelle"; // Utilise la propriété qui contient le libellé du motif
            colMotif.HeaderText = "Motif";
            colMotif.Name = "colMotif";

            // Optionnel : cacher l'idpersonnel et idmotif si non pertinent pour l'utilisateur ici
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
        public void ChargerAbsences() // Public pour pouvoir la rafraîchir
        {
            if (personnelConcerne != null)
            {
                List<Absence> lesAbsences = controller.GetLesAbsences(personnelConcerne.IdPersonnel);
                bsAbsences.DataSource = lesAbsences;
            }
        }

        // Gestionnaire pour le bouton Fermer
        // Assure-toi que ton bouton s'appelle btnFermerAbsences
        private void btnFermerAbsences_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}