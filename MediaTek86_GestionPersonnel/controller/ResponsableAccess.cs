using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86_GestionPersonnel.bddmanager;


namespace MediaTek86_GestionPersonnel.dal
{
    /// <summary>
    /// Gère l'accès aux données de la table 'responsable'.
    /// </summary>
    public class ResponsableAccess
    {
        private readonly BddManager bddManager;

        /// <summary>
        /// Constructeur. Initialise BddManager.
        /// </summary>
        public ResponsableAccess()
        {
            // Utilise la classe Access pour obtenir l'instance de BddManager
            this.bddManager = Access.GetInstance().Manager;
        }

        /// <summary>
        /// Vérifie les identifiants d'un responsable dans la base de données.
        /// </summary>
        /// <param name="login">Le login à vérifier.</param>
        /// <param name="pwd">Le mot de passe à vérifier (en clair, sera hashé pour la comparaison).</param>
        /// <returns>True si les identifiants correspondent, False sinon.</returns>
        public bool VerifierIdentifiants(string login, string pwd)
        {

            string req = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd); 

            try
            {
                List<object[]> result = bddManager.ReqSelect(req, parameters);
                if (result != null && result.Count > 0)
                {

                    long count = (long)result[0][0];
                    return count > 0;
                }
            }
            catch (System.Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("Erreur lors de la vérification des identifiants : " + ex.Message);
            }
            return false;
        }
    }
}