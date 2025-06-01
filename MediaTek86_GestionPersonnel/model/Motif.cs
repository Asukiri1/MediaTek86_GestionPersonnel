using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_GestionPersonnel.model
{
    /// <summary>
    /// Représente un motif d'absence.
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Obtient ou définit l'identifiant unique du motif.
        /// </summary>
        public int IdMotif { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du motif.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Motif"/>.
        /// </summary>
        /// <param name="idMotif">L'identifiant du motif.</param>
        /// <param name="libelle">Le libellé du motif.</param>
        public Motif(int idMotif, string libelle)
        {
            this.IdMotif = idMotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Retourne le libellé du motif pour l'affichage (par exemple, dans une ComboBox).
        /// </summary>
        /// <returns>Le libellé du motif.</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
