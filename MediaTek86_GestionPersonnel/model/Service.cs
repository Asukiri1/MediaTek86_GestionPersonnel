using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_GestionPersonnel.model
{
    /// <summary>
    /// Représente un service au sein de la médiathèque.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Obtient ou définit l'identifiant unique du service.
        /// </summary>
        public int IdService { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du service.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Service"/>.
        /// </summary>
        /// <param name="idService">L'identifiant du service.</param>
        /// <param name="nom">Le nom du service.</param>
        public Service(int idService, string nom)
        {
            this.IdService = idService;
            this.Nom = nom;
        }

        /// <summary>
        /// Retourne le nom du service pour l'affichage (par exemple, dans une ComboBox).
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}