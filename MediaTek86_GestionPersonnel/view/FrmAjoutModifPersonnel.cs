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
using MediaTek86_GestionPersonnel.model;

namespace MediaTek86_GestionPersonnel.view
{
    public partial class FrmAjoutModifPersonnel : Form
    {
        private readonly FrmGestionPersonnelController controller;
        private readonly Personnel personnelAEditer; 
        private List<Service> lesServices; 

        /// <summary>
        /// Constructeur pour le mode Ajout.
        /// </summary>
        /// <param name="controller">Le contrôleur principal.</param>
        public FrmAjoutModifPersonnel(FrmGestionPersonnelController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.personnelAEditer = null; 
            this.Text = "Ajouter un personnel";
            ChargerServices();
        }

        /// <summary>
        /// Constructeur pour le mode Modification (sera utilisé plus tard).
        /// </summary>
        /// <param name="controller">Le contrôleur principal.</param>
        /// <param name="personnel">Le personnel à modifier.</param>
        public FrmAjoutModifPersonnel(FrmGestionPersonnelController controller, Personnel personnel)
        {
            InitializeComponent();
            this.controller = controller;
            this.personnelAEditer = personnel;
            this.Text = "Modifier le personnel : " + personnel.Nom + " " + personnel.Prenom;
            ChargerServices();
            AfficherInfosPersonnel(); 
        }

        /// <summary>
        /// Charge la liste des services dans la ComboBox.
        /// </summary>
        private void ChargerServices()
        {
            lesServices = controller.GetAllServices();
            cmbService.DataSource = lesServices;
            cmbService.DisplayMember = "Nom"; 
            cmbService.ValueMember = "IdService"; 
            cmbService.SelectedIndex = -1; 
        }

        /// <summary>
        /// Pré-remplit les champs si en mode Modification.
        /// </summary>
        private void AfficherInfosPersonnel()
        {
            if (personnelAEditer != null)
            {
                txtNom.Text = personnelAEditer.Nom;
                txtPrenom.Text = personnelAEditer.Prenom;
                txtTel.Text = personnelAEditer.Tel;
                txtMail.Text = personnelAEditer.Mail;
                cmbService.SelectedValue = personnelAEditer.IdService;
            }
        }

        /// <summary>
        /// Gère le clic sur le bouton Enregistrer.
        /// </summary>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Valider les champs
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs doivent être remplis et un service doit être sélectionné.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer les valeurs
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string tel = txtTel.Text;
            string mail = txtMail.Text;
            int idService = (int)cmbService.SelectedValue;
            // Récupérer le nom du service sélectionné pour la propriété ServiceNom de l'objet Personnel
            string serviceNom = "";
            if (cmbService.SelectedItem != null) // S'assurer qu'un item est bien sélectionné
            {
                serviceNom = ((Service)cmbService.SelectedItem).Nom;
            }


            if (personnelAEditer == null) // Mode Ajout
            {
                // Crée un nouvel objet Personnel
                Personnel nouveauPersonnel = new Personnel(0, nom, prenom, tel, mail, idService, serviceNom);

                if (controller.AjouterPersonnel(nouveauPersonnel))
                {
                    MessageBox.Show("Personnel ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Mode Modification
            {
                // Mettre à jour l'objet personnelAEditer avec les nouvelles valeurs
                personnelAEditer.Nom = nom;
                personnelAEditer.Prenom = prenom;
                personnelAEditer.Tel = tel;
                personnelAEditer.Mail = mail;
                personnelAEditer.IdService = idService;
                personnelAEditer.ServiceNom = serviceNom; 

                if (controller.ModifierPersonnel(personnelAEditer))
                {
                    MessageBox.Show("Personnel modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Gère le clic sur le bouton Annuler.
        /// </summary>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}