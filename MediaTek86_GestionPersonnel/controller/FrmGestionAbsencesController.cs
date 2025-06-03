using MediaTek86_GestionPersonnel.dal;
using MediaTek86_GestionPersonnel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86_GestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur pour la fenêtre de gestion des absences d'un personnel.
    /// </summary>
    public class FrmGestionAbsencesController
    {
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public FrmGestionAbsencesController()
        {
            this.absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère les absences pour un personnel spécifique.
        /// </summary>
        /// <param name="idPersonnel">L'ID du personnel.</param>
        /// <returns>Une liste d'objets Absence.</returns>
        public List<Absence> GetLesAbsences(int idPersonnel)
        {
            return absenceAccess.GetAbsences(idPersonnel);
        }

        /// <summary>
        /// Récupère tous les motifs d'absence.
        /// </summary>
        /// <returns>Une liste d'objets Motif.</returns>
        public List<Motif> GetAllMotifs()
        {
            return absenceAccess.GetAllMotifs();
        }
        /// <summary>
        /// Demande l'ajout d'une nouvelle absence.
        /// </summary>
        /// <param name="absence">L'absence à ajouter.</param>
        /// <returns>True si l'ajout a réussi, False sinon.</returns>
        public bool AjouterAbsence(Absence absence)
        {
            return absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande la mise à jour d'une absence existante.
        /// </summary>
        /// <param name="absenceModifiee">L'absence avec les informations mises à jour.</param>
        /// <param name="dateDebutOriginale">La date de début originale de l'absence à modifier.</param>
        /// <returns>True si la mise à jour a réussi, False sinon.</returns>
        public bool ModifierAbsence(Absence absenceModifiee, DateTime dateDebutOriginale)
        {
            if (absenceModifiee == null) return false;
            if (absenceModifiee.DateFin < absenceModifiee.DateDebut)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return absenceAccess.UpdateAbsence(absenceModifiee, dateDebutOriginale);
        }
    }
}



