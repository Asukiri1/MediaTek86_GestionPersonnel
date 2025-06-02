using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86_GestionPersonnel.bddmanager;
using MediaTek86_GestionPersonnel.model;


namespace MediaTek86_GestionPersonnel.dal
{
    /// <summary>
    /// Gère l'accès aux données de la table 'personnel' et des informations liées (services).
    /// </summary>
    public class PersonnelAccess
    {
        private readonly BddManager bddManager;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public PersonnelAccess()
        {
            this.bddManager = Access.GetInstance().Manager;
        }

        /// <summary>
        /// Récupère tous les membres du personnel avec le nom de leur service.
        /// </summary>
        /// <returns>Une liste d'objets Personnel.</returns>
        public List<Personnel> GetAllPersonnel()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            // Requête SQL
            string req = "SELECT p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, p.idservice, s.nom AS service_nom ";
            req += "FROM personnel p JOIN service s ON p.idservice = s.idservice ORDER BY p.nom, p.prenom;";

            try
            {
                List<object[]> records = bddManager.ReqSelect(req);
                foreach (object[] record in records)
                {
                    
                    Personnel personnel = new Personnel(
                        (int)record[0],      // idpersonnel
                        (string)record[1],   // nom
                        (string)record[2],   // prenom
                        (string)record[3],   // tel
                        (string)record[4],   // mail
                        (int)record[5],      // idservice
                        (string)record[6]    // service_nom
                    );
                    lesPersonnels.Add(personnel);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans GetAllPersonnel : " + e.Message);
                
            }
            return lesPersonnels;
        }

        
    }
}