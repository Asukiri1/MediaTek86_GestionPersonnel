using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86_GestionPersonnel.controller;

namespace MediaTek86_GestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de connexion permettant à l'utilisateur de s'authentifier.
    /// </summary>
    public partial class FrmConnexion : Form
    {
        private readonly FrmConnexionController controller;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmConnexion"/>.
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            this.controller = new FrmConnexionController();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Le login et le mot de passe ne peuvent pas être vides.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (controller.VerifierAuthentification(login, pwd))
            {
                // Authentification réussie
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cacher la fenêtre de connexion
                this.Hide();

                // Créer et afficher la fenêtre principale
                FrmGestionPersonnel frmGestionPersonnel = new FrmGestionPersonnel();
                frmGestionPersonnel.ShowDialog(); // ShowDialog pour la rendre modale jusqu'à sa fermeture
                this.Close();
            }
            else
            {
                // Authentification échouée
                MessageBox.Show("Login ou mot de passe incorrect.", "Échec de la connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Clear();
                txtLogin.Focus();
            }
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}