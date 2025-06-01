using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MediaTek86_GestionPersonnel.model
{
    /// <summary>
    /// Représente une période d'absence pour un membre du personnel.
    /// </summary>
    public class Absence
    {

        /// <summary>
        /// Obtient ou définit l'identifiant du personnel concerné par l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Obtient ou définit la date de début de l'absence.
        /// L'heure sera stockée à 00:00:00 si non spécifiée lors de l'insertion.
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Obtient ou définit la date de fin de l'absence.
        /// L'heure sera stockée à 00:00:00 si non spécifiée lors de l'insertion.
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du motif de l'absence.
        /// </summary>
        public int IdMotif { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du motif de l'absence.
        /// </summary>
        public string MotifLibelle { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Absence"/>.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        /// <param name="idMotif">L'identifiant du motif.</param>
        /// <param name="motifLibelle">Le libellé du motif (pour affichage).</param>
        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif, string motifLibelle)
        {
            this.IdPersonnel = idPersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.IdMotif = idMotif;
            this.MotifLibelle = motifLibelle;
        }
    }
}