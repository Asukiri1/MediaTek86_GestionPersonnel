using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_GestionPersonnel.model
{
    /// <summary>
    /// Représente un membre du personnel.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Obtient ou définit l'identifiant unique du personnel.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de famille du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou définit le prénom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Obtient ou définit l'adresse e-mail du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du service auquel le personnel est affecté.
        /// </summary>
        public int IdService { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du service du personnel.
        /// </summary>
        public string ServiceNom { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Personnel"/>.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant du personnel.</param>
        /// <param name="nom">Le nom de famille.</param>
        /// <param name="prenom">Le prénom.</param>
        /// <param name="tel">Le numéro de téléphone.</param>
        /// <param name="mail">L'adresse e-mail.</param>
        /// <param name="idService">L'identifiant du service d'affectation.</param>
        /// <param name="serviceNom">Le nom du service d'affectation (pour affichage).</param>
        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService, string serviceNom)
        {
            this.IdPersonnel = idPersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.IdService = idService;
            this.ServiceNom = serviceNom;
        }

        
    }
}