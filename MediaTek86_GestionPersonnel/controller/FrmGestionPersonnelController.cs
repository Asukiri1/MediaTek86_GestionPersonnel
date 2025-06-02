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
    /// Contrôleur pour la fenêtre de gestion du personnel.
    /// </summary>
    public class FrmGestionPersonnelController
    {
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public FrmGestionPersonnelController()
        {
            this.personnelAccess = new PersonnelAccess();
        }

        /// <summary>
        /// Récupère la liste de tout le personnel.
        /// </summary>
        /// <returns>Une liste d'objets Personnel.</returns>
        public List<Personnel> GetLePersonnel()
        {
            return personnelAccess.GetAllPersonnel();
        }
    
     /// <summary>
    /// Récupère la liste de tous les services.
    /// </summary>
    /// <returns>Une liste d'objets Service.</returns>
    public List<Service> GetAllServices()
        {
            return personnelAccess.GetAllServices();
        }

        /// <summary>
        /// Demande l'ajout d'un nouveau personnel.
        /// </summary>
        /// <param name="personnel">Le personnel à ajouter.</param>
        /// <returns>True si l'ajout a réussi, False sinon.</returns>
        public bool AjouterPersonnel(Personnel personnel)
        {

            if (personnel == null) return false;

            return personnelAccess.AddPersonnel(personnel);
        }
    }

}