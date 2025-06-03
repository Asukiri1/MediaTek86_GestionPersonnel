using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86_GestionPersonnel.dal;
using MediaTek86_GestionPersonnel.model;

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

    }
}



