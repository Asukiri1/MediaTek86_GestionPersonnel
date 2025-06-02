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
        public List<Service> GetAllServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT idservice, nom FROM service ORDER BY nom;";
            try
            {
                List<object[]> records = bddManager.ReqSelect(req);
                foreach (object[] record in records)
                {
                    Service service = new Service(
                        (int)record[0],      // idservice
                        (string)record[1]    // nom
                    );
                    lesServices.Add(service);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans GetAllServices : " + e.Message);
            }
            return lesServices;
        }

        /// <summary>
        /// Ajoute un nouveau personnel à la base de données.
        /// </summary>
        /// <param name="personnel">L'objet Personnel contenant les informations à ajouter.</param>
        /// <returns>True si l'ajout a réussi, False sinon.</returns>
        public bool AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) ";
            req += "VALUES (@nom, @prenom, @tel, @mail, @idservice);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.IdService);

            try
            {
                bddManager.ReqUpdate(req, parameters);
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans AddPersonnel : " + e.Message);
                return false;
            }
        }
        /// <summary>
        /// Met à jour les informations d'un personnel existant dans la base de données.
        /// </summary>
        /// <param name="personnel">L'objet Personnel contenant les informations mises à jour.</param>
        /// <returns>True si la mise à jour a réussi, False sinon.</returns>
        public bool UpdatePersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "WHERE idpersonnel = @idpersonnel;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@idpersonnel", personnel.IdPersonnel); 

            try
            {
                bddManager.ReqUpdate(req, parameters);
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans UpdatePersonnel : " + e.Message);
                return false;
            }
        }
    }
}



