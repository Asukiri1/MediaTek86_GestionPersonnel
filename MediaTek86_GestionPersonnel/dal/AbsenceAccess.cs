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
    /// Gère l'accès aux données de la table 'absence' et des informations liées (motifs).
    /// </summary>
    public class AbsenceAccess
    {
        private readonly BddManager bddManager;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public AbsenceAccess()
        {
            this.bddManager = Access.GetInstance().Manager;
        }

        /// <summary>
        /// Récupère toutes les absences pour un personnel donné, avec le libellé du motif.
        /// Les absences sont triées par date de début, la plus récente en premier.
        /// </summary>
        /// <param name="idPersonnel">L'ID du personnel dont on veut les absences.</param>
        /// <returns>Une liste d'objets Absence.</returns>
        public List<Absence> GetAbsences(int idPersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, a.idmotif, m.libelle AS motif_libelle ";
            req += "FROM absence a JOIN motif m ON a.idmotif = m.idmotif ";
            req += "WHERE a.idpersonnel = @idpersonnel ORDER BY a.datedebut DESC;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idPersonnel);

            try
            {
                List<object[]> records = bddManager.ReqSelect(req, parameters);
                foreach (object[] record in records)
                {
                    Absence absence = new Absence(
                        (int)record[0],         // idpersonnel
                        (DateTime)record[1],    // datedebut
                        (DateTime)record[2],    // datefin
                        (int)record[3],         // idmotif
                        (string)record[4]       // motif_libelle
                    );
                    lesAbsences.Add(absence);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans GetAbsences : " + e.Message);
            }
            return lesAbsences;
        }

        /// <summary>
        /// Récupère tous les motifs d'absence.
        /// </summary>
        /// <returns>Une liste d'objets Motif.</returns>
        public List<Motif> GetAllMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT idmotif, libelle FROM motif ORDER BY libelle;";
            try
            {
                List<object[]> records = bddManager.ReqSelect(req);
                foreach (object[] record in records)
                {
                    Motif motif = new Motif(
                        (int)record[0],      // idmotif
                        (string)record[1]    // libelle
                    );
                    lesMotifs.Add(motif);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans GetAllMotifs (AbsenceAccess) : " + e.Message);
            }
            return lesMotifs;

        }   
        /// <summary>
        /// Ajoute une nouvelle absence à la base de données.
        /// </summary>
        /// <param name="absence">L'objet Absence contenant les informations à ajouter.</param>
        /// <returns>True si l'ajout a réussi, False sinon.</returns>
        public bool AddAbsence(Absence absence)
        {
            string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) ";
            req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut); // Doit être au format YYYY-MM-DD pour la BDD
            parameters.Add("@datefin", absence.DateFin);   // Pareil
            parameters.Add("@idmotif", absence.IdMotif);

            try
            {
                bddManager.ReqUpdate(req, parameters);
                return true;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Erreur dans AddAbsence : " + e.Message);
                return false;
            }
        }
    }
}


