using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86_GestionPersonnel.dal;

namespace MediaTek86_GestionPersonnel.controller
{
    /// <summary>
    /// Contrôleur pour la fenêtre de connexion.
    /// </summary>
    public class FrmConnexionController
    {
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Constructeur du contrôleur de connexion.
        /// Initialise l'accès aux données des responsables.
        /// </summary>
        public FrmConnexionController()
        {
            this.responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Tente de vérifier les informations d'identification de l'utilisateur.
        /// </summary>
        /// <param name="login">Le login saisi.</param>
        /// <param name="pwd">Le mot de passe saisi.</param>
        /// <returns>True si les identifiants sont valides, False sinon.</returns>
        public bool VerifierAuthentification(string login, string pwd)
        {
            // Valider les entrées (non vide, etc.) - Peut être fait ici ou dans la vue avant d'appeler
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pwd))
            {
                return false;
            }
            return responsableAccess.VerifierIdentifiants(login, pwd);
        }
    }
}
