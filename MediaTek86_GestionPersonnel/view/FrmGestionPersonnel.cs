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
    public partial class FrmGestionPersonnel : Form
    {
        // Déclaration du contrôleur et du BindingSource
        private readonly FrmGestionPersonnelController controller;
        private BindingSource bsPersonnel; 

        public FrmGestionPersonnel()
        {
            InitializeComponent();
            this.controller = new FrmGestionPersonnelController();
            this.bsPersonnel = new BindingSource();

            // Lier le DataGridView au BindingSource
           
            
            if (this.dgvPersonnel != null) 
            {
                dgvPersonnel.DataSource = bsPersonnel;
                ConfigurerDataGridView();
                ChargerPersonnel();
            }
            else
            {
                // Gérer le cas où dgvPersonnel n'est pas trouvé (message d'erreur, log)
               
                MessageBox.Show("Le contrôle DataGridView 'dgvPersonnel' n'a pas été trouvé sur le formulaire.", "Erreur de Configuration UI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configure l'apparence et les colonnes du DataGridView.
        /// </summary>
        private void ConfigurerDataGridView()
        {
            
            if (this.dgvPersonnel == null) return;

            dgvPersonnel.AutoGenerateColumns = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPersonnel.AllowUserToAddRows = false;
            dgvPersonnel.AllowUserToDeleteRows = false;
            dgvPersonnel.ReadOnly = true;
            dgvPersonnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Vider les colonnes existantes au cas où (si cette méthode est appelée plusieurs fois)
            dgvPersonnel.Columns.Clear();

            // Définir les colonnes
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdPersonnel"; 
            colId.HeaderText = "ID";
            colId.Name = "colIdPersonnel"; 
            colId.Visible = false;

            DataGridViewTextBoxColumn colNom = new DataGridViewTextBoxColumn();
            colNom.DataPropertyName = "Nom";
            colNom.HeaderText = "Nom";
            colNom.Name = "colNom";

            DataGridViewTextBoxColumn colPrenom = new DataGridViewTextBoxColumn();
            colPrenom.DataPropertyName = "Prenom";
            colPrenom.HeaderText = "Prénom";
            colPrenom.Name = "colPrenom";

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.DataPropertyName = "Tel";
            colTel.HeaderText = "Téléphone";
            colTel.Name = "colTel";

            DataGridViewTextBoxColumn colMail = new DataGridViewTextBoxColumn();
            colMail.DataPropertyName = "Mail";
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";

            DataGridViewTextBoxColumn colServiceNom = new DataGridViewTextBoxColumn();
            colServiceNom.DataPropertyName = "ServiceNom"; 
            colServiceNom.HeaderText = "Service";
            colServiceNom.Name = "colServiceNom";

            dgvPersonnel.Columns.AddRange(new DataGridViewColumn[] { colId, colNom, colPrenom, colTel, colMail, colServiceNom });
        }

        /// <summary>
        /// Charge ou met à jour la liste du personnel dans le DataGridView.
        /// </summary>
        public void ChargerPersonnel() 
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bsPersonnel.DataSource = lePersonnel;

        }


        
        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            // Vérifier si un personnel est sélectionné dans dgvPersonnel
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                // Récupérer l'objet Personnel sélectionné
                Personnel personnelSelectionne = (Personnel)bsPersonnel.Current;

                if (personnelSelectionne != null)
                {
                    //Ouvrir FrmAjoutModifPersonnel en mode "modification" avec les données du personnel
                    FrmAjoutModifPersonnel frmModif = new FrmAjoutModifPersonnel(this.controller, personnelSelectionne);
                    DialogResult resultat = frmModif.ShowDialog();

                    //Si FrmAjoutModifPersonnel retourne OK, rafraîchir la liste
                    if (resultat == DialogResult.OK)
                    {
                        ChargerPersonnel();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            //Vérifier si un personnel est sélectionné
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnelSelectionne = (Personnel)bsPersonnel.Current; 

                if (personnelSelectionne != null)
                {
                    //Demander confirmation à l'utilisateur
                    DialogResult confirmation = MessageBox.Show(
                        $"Êtes-vous sûr de vouloir supprimer le personnel '{personnelSelectionne.Prenom} {personnelSelectionne.Nom}' ainsi que toutes ses absences associées ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmation == DialogResult.Yes)
                    {
                        if (controller.SupprimerPersonnel(personnelSelectionne.IdPersonnel))
                        {
                            MessageBox.Show("Personnel et ses absences supprimés avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChargerPersonnel();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression du personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAjouterPersonnel_Click(object sender, EventArgs e) 
        {
            // Ouvre FrmAjoutModifPersonnel en mode Ajout
            FrmAjoutModifPersonnel frmAjout = new FrmAjoutModifPersonnel(this.controller);
            DialogResult resultat = frmAjout.ShowDialog(); 

            if (resultat == DialogResult.OK)
            {
                ChargerPersonnel(); // Rafraîchir la liste si un personnel a été ajouté
            }
        }


    }
}