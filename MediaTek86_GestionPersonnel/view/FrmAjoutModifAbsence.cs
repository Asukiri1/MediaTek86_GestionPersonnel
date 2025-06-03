using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86_GestionPersonnel.controller;
using MediaTek86_GestionPersonnel.model;

namespace MediaTek86_GestionPersonnel.view
{
    public partial class FrmAjoutModifAbsence : Form
    {
        private readonly FrmGestionAbsencesController controller;
        private readonly Personnel personnelConcerne; 
        private readonly Absence absenceAEditer; 
        private List<Motif> lesMotifs;
        private DateTime dateDebutOriginalePourModif; //Stocker la date de début originale en mode modif


        /// <summary>
        /// Constructeur pour le mode Ajout.
        /// </summary>
        /// <param name="controllerAbsences">Le contrôleur des absences.</param>
        /// <param name="personnel">Le personnel concerné.</param>
        public FrmAjoutModifAbsence(FrmGestionAbsencesController controllerAbsences, Personnel personnel)
        {
            InitializeComponent();
            this.controller = controllerAbsences;
            this.personnelConcerne = personnel;
            this.absenceAEditer = null;
            this.Text = "Ajouter une absence pour " + personnel.Prenom + " " + personnel.Nom;
            ChargerMotifs();
            // Initialiser les DateTimePickers
            dtpDateDebut.Value = DateTime.Today;
            dtpDateFin.Value = DateTime.Today;
        }

        /// <summary>
        /// Constructeur pour le mode Modification
        /// </summary>
        /// <param name="controllerAbsences">Le contrôleur des absences.</param>
        /// <param name="personnel">Le personnel concerné.</param>
        /// <param name="absence">L'absence à modifier.</param>
        public FrmAjoutModifAbsence(FrmGestionAbsencesController controllerAbsences, Personnel personnel, Absence absence)
        {
            InitializeComponent();
            this.controller = controllerAbsences;
            this.personnelConcerne = personnel;
            this.absenceAEditer = absence;
            //Stocker uniquement la partie DATE de la date de début originale pour pas être embetté par l'heure lors de la modification
            this.dateDebutOriginalePourModif = absence.DateDebut.Date;
            this.Text = "Modifier l'absence de " + personnel.Prenom + " " + personnel.Nom;
            ChargerMotifs();
            AfficherInfosAbsence(); 
        }
        /// <summary>
        /// Charge la liste des motifs dans la ComboBox.
        /// </summary>
        private void ChargerMotifs()
        {
            lesMotifs = controller.GetAllMotifs();
            cmbMotif.DataSource = lesMotifs;
            cmbMotif.DisplayMember = "Libelle"; 
            cmbMotif.ValueMember = "IdMotif";   
            cmbMotif.SelectedIndex = -1;
        }

        /// <summary>
        /// Pré-remplit les champs si en mode Modification.
        /// </summary>
        private void AfficherInfosAbsence()
        {
            if (absenceAEditer != null)
            {
                dtpDateDebut.Value = absenceAEditer.DateDebut; // Conserve l'heure originale pour l'affichage initial
                dtpDateFin.Value = absenceAEditer.DateFin;     // Pareil
                cmbMotif.SelectedValue = absenceAEditer.IdMotif;
            }
        }

        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (cmbMotif.SelectedIndex == -1 || dtpDateFin.Value < dtpDateDebut.Value)
            {
                if (cmbMotif.SelectedIndex == -1)
                    MessageBox.Show("Un motif doit être sélectionné.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dtpDateFin.Value < dtpDateDebut.Value)
                    MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DateTime dateDebut = dtpDateDebut.Value.Date;
            DateTime dateFin = dtpDateFin.Value.Date;
            int idMotif = (int)cmbMotif.SelectedValue;
            string motifLibelle = ((Motif)cmbMotif.SelectedItem).Libelle;

            if (absenceAEditer == null)
            {
                Absence nouvelleAbsence = new Absence(personnelConcerne.IdPersonnel, dateDebut, dateFin, idMotif, motifLibelle);

                if (controller.AjouterAbsence(nouvelleAbsence))
                {
                    MessageBox.Show("Absence ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                    if (dtpDateFin.Value >= dtpDateDebut.Value)
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'absence. Vérifiez qu'il n'y a pas de chevauchement avec une absence existante.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // Mode Modification 
            {
                absenceAEditer.DateDebut = dateDebut;
                absenceAEditer.DateFin = dateFin;
                absenceAEditer.IdMotif = idMotif;
                absenceAEditer.MotifLibelle = motifLibelle;


                if (controller.ModifierAbsence(absenceAEditer, this.dateDebutOriginalePourModif))
                {
                    MessageBox.Show("Absence modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (dtpDateFin.Value >= dtpDateDebut.Value)
                    {
                        MessageBox.Show("Erreur lors de la modification de l'absence. Vérifiez qu'il n'y a pas de chevauchement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}