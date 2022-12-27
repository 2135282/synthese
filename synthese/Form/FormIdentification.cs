using synthese.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synthese
{
    public partial class FormIdentification : Form
    {
        public FormIdentification()
        {
            InitializeComponent();
        }

        private void FormIdentification_Load(object sender, EventArgs e)
        {

        }

        public void InitialiserLabel()
        {
            //Initialiser les labels d'erreur
            lblErreurPrenom.Text = lblErreurNomTitre.Text = lblErreurCourrielQuantite.Text = lblErreurNoTelPages.Text = "";
            lblErreurNoIdentifFilm.Text = lblErreurCb.Text = "";
        }

        // ** Exercice GestElection **
        /// <summary>
        /// Vérifier la correspondance entre le champ entré dans la textBox et le modèle
        /// avec Regex
        /// </summary>
        /// <param name="modele">Modele</param>
        /// <param name="tb">TextBox</param>
        /// <param name="lbl">Label</param>
        /// <param name="messageErreur">Message d'erreur</param>
        /// <returns>True si les informations correspondent au modèle ou False avec un message d'erreur si elles ne correspondent pas</returns>
        public bool VerifierRegex(string modele, TextBox tb, System.Windows.Forms.Label lbl, string messageErreur)
        {
            // Créer du Regex reg
            Regex reg = new Regex(modele);
            //Vérifier la correspondance entre le champ entré dans la textBox et le modèle
            if (!reg.IsMatch(tb.Text))
            {
                //Afficher un message d'erreur
                lbl.ForeColor = Color.Red;
                lbl.Text = messageErreur;
                //Effacer la TextBox
                tb.Clear();
                return false;
            }
            else lbl.Text = "";     //Effacer le label si le champ est bon
            return true;
        }

        /// <summary>
        /// Vérifier le comboBox
        /// </summary>
        /// <param name="cb">ComboBox</param>
        /// <param name="lbl">Label</param>
        /// <returns>True si l'utilisateur à choisi une option si non False si il n'a rien choisi</returns>
        public bool VerifierComboBox(ComboBox cb, System.Windows.Forms.Label lbl)
        {
            // Si l'utilisateur a choisi une valeur de la liste
            if (cb.Text != "") { lbl.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lbl.ForeColor = Color.Red; lbl.Text = "Choisissez un type d'usager"; return false;
            }
        }

        /// <summary>
        /// Vérifier chaque champs en fonction des restrictions
        /// </summary>
        /// <returns>True si toutes les fonctions suivent les restrictions ou False si elles ne les suivent pas</returns>
        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_prenom, b_nom, b_courriel, b_telephone, b_identification, b_combobox;
            //Appel de la méthode VerifierRegex pour tous les champs
            //Récupération des valeurs retournées dans les variables bouléennes
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{5,10}$", txtboxPrenom, lblErreurPrenom, "Lettre majuscule suivie de 5 à 15 lettres minuscules");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{5,10}$", txtboxNom, lblErreurNomTitre, "Lettre majuscule suivie de 5 à 15 lettres minuscules");
            b_courriel = VerifierRegex(@"^[a-zA-Z0-9]{5,12}@[a-zA-Z0-9]{5,12}\.[a-zA-Z]{2,3}$", txtboxCourriel, lblErreurCourrielQuantite, 
                "5 à 12 caractères alphanum +@+5 à 12 caractères alphanumériques+.+un mot de 2 ou 3 lettres");
            b_telephone = VerifierRegex(@"(^\(\d{3}\)\ \d{3}\-\d{4})$", txtboxNoTelephone, lblErreurNoTelPages, "(XXX) XXX-XXXX");
            b_identification = VerifierRegex("^[0-9]{5}$", txtNoIdentification, lblErreurNoIdentifFilm, "Cinq chiffres");
            //Vérifier que l'utilisateur a sélectionné un type d'usager
            b_combobox = VerifierComboBox(comboBoxUsager, lblErreurCb);
            // Si toutes les vérifications sont valides retourner vrai
            if (b_prenom && b_nom && b_courriel && b_telephone
               && b_identification && b_combobox)
                return true;
            else return false; //Sinon retourner faux
        }

        /// <summary>
        /// Réinitialiser tous les champs du formulaire
        /// </summary>
        public void InitialiserControles()
        {
            txtboxPrenom.Text = "";
            txtboxNom.Text = "";
            txtboxCourriel.Text = "";
            txtboxNoTelephone.Text = "";
            txtNoIdentification.Text = "";
            comboBoxUsager.SelectedIndex = -1; //Permet de réinitialiser la ComboBox
        }

        /// <summary>
        /// Sauvegarder les données des clients dans la base de données
        /// </summary>
        public void SauvegarderClient()
        {
            // ** Exercice Laboratoire_Mode_deconnecte **
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            Client cli = new Client();
            try
            {
            // Sauvegarde dans la base de données
            SqlCommandBuilder builder = new SqlCommandBuilder(cli.Adapter);
            //Appeler la méthode Update de l’adapteur.
            //Elle prend en paramètres le DataSet, et le nom de la table.	
            cli.Adapter.Update(cli.DsClients, cli.DtProjetSynthese.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Sauvegarder les données des Articles dans la base de données
        /// </summary>
        public void SauvegarderArticles()
        {
            // ** Exercice Laboratoire_Mode_deconnecte **
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            Articles art = new Articles();
            try
            {
                // Sauvegarde dans la base de données
                SqlCommandBuilder builder = new SqlCommandBuilder(art.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                art.Adapter.Update(art.DsArticles, art.DtProjetSynthese.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtboxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        // Ajouter un client
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Instancier un objet DataRow (une ligne de la table): DataRow UnArticle
            // Le classe DataRow se trouve dans System.Data
            // Affecter à l'objet DataRow Unetudiant le même schéma que la table
            // c'est à dire: Prenom, Nom, NoTelephone, Courriel, NoIdentification, TypeClient
            Client cli = new Client();
            DataRow UnClient = cli.DtProjetSynthese.NewRow();

            VerifierTous();     // Si tous les champs entrés sont valides
            // Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnEtudiant
            UnClient[0] = txtboxPrenom.Text.Trim();
            UnClient[1] = txtboxNom.Text.Trim();
            UnClient[2] = txtboxNoTelephone.Text.Trim();
            UnClient[3] = txtboxCourriel.Text.Trim();
            UnClient[4] = txtNoIdentification.ToString().Trim();
            UnClient[5] = comboBoxUsager.ToString().Trim();
            InitialiserControles();     //Effacer les messages d'erreurs
            SauvegarderClient();              // Sauvegarder les modifications
        }
        private void btnEmprunter_Click(object sender, EventArgs e)
        {

        }

        // Modifier Client
        private void btnModifArticle_Click(object sender, EventArgs e)
        {
            Client cli = new Client();
            DataRow UnClient = cli.DtProjetSynthese.NewRow();
            //Parcourir les lignes de la table cli.DtProjetSynthese
            foreach (DataRow row in cli.DtProjetSynthese.Rows)
            {
                //Trouver la ligne qui correspond au numéro d'identification entré par l'usager
                if (row[4].ToString() == txtNoIdentification.Text)
                {
                    VerifierTous();     // Si tous les champs entrés sont valides
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    row[0] = txtboxPrenom.Text.Trim();
                    row[1] = txtboxNom.Text.Trim();
                    row[2] = txtboxNoTelephone.Text.Trim();
                    row[3] = txtboxCourriel.Text.Trim();
                    row[5] = comboBoxUsager.ToString().Trim();
                    InitialiserControles();     //Effacer les messages d'erreurs
                    SauvegarderClient();              // Sauvegarder les modifications
                }
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Client cli = new Client();
            DataRow UnClient = cli.DtProjetSynthese.NewRow();
            //Parcourir les lignes de la table cli.DtProjetSynthese
            foreach (DataRow row in cli.DtProjetSynthese.Rows)
            {
                //Trouver la ligne qui correspond au numéro d'identification entré par l'usager
                if (row[4].ToString() == txtNoIdentification.Text)
                {
                    //Supprimer la ligne correspondant au numéro d'identification
                    row[0] = 
                    row[1] = 
                    row[2] = 
                    row[3] = 
                    row[4] = 
                    row[5] = 
                    InitialiserControles();     //Effacer les messages d'erreurs
                    SauvegarderClient();              // Sauvegarder les modifications
                }
            }


        }

        // Ajouter un article
        private void btnAjoutArticle_Click_1(object sender, EventArgs e)
        {
            // Instancier un objet DataRow (une ligne de la table): DataRow UnArticle
            // Le classe DataRow se trouve dans System.Data
            // Affecter à l'objet DataRow UnArticle le même schéma que la table
            // c'est à dire: NbPages, Duree, Titre, Quantite, TypeArticle
            Articles art = new Articles();
            DataRow UnArticles = art.DtProjetSynthese.NewRow();

            VerifierTous();     // Si tous les champs entrés sont valides
            // Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnEtudiant
            UnArticles[0] = txtBoxPages.Text.Trim();
            UnArticles[1] = txtDuree.Text.Trim();
            UnArticles[2] = txtboxTitre.Text.Trim();
            UnArticles[3] = txtBoxQuantite.ToString().Trim();
            UnArticles[4] = comboBoxArticle.ToString().Trim();
            InitialiserControles();             //Effacer les messages d'erreurs
            SauvegarderArticles();              // Sauvegarder les modifications
        }

        private void btnSupArticle_Click_1(object sender, EventArgs e)
        {
            Articles art = new Articles();
            DataRow UnArticles = art.DtProjetSynthese.NewRow();
            foreach (DataRow row in art.DtProjetSynthese.Rows)
            {

            }
        }

        // Modifier article
        private void btnModifArticle_Click_1(object sender, EventArgs e)
        {
            Articles art = new Articles();
            DataRow UnArticles = art.DtProjetSynthese.NewRow();
            //Parcourir les lignes de la table cli.DtProjetSynthese
            foreach (DataRow row in art.DtProjetSynthese.Rows)
            {
                //Trouver la ligne qui correspond au numéro d'identification entré par l'usager
                if (row[2].ToString() == txtboxTitre.Text)
                {
                    VerifierTous();     // Si tous les champs entrés sont valides
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    row[0] = txtBoxPages.Text.Trim();
                    row[1] = txtDuree.Text.Trim();
                    row[2] = txtboxTitre.Text.Trim();
                    row[3] = txtBoxQuantite.ToString().Trim();
                    row[4] = comboBoxArticle.ToString().Trim();
                    InitialiserControles();             //Effacer les messages d'erreurs
                    SauvegarderArticles();              // Sauvegarder les modifications
                }
            }
        }
    }
}
