using synthese.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            lblErreurPrenom.Text = lblErreurNom.Text = lblErreurCourriel.Text = lblErreurNoTel.Text = "";
            lblErreurNoIdentification.Text = lblErreurCb.Text = "";
        }

        // ** Exercice GestElection **
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

        public bool VerifierComboBox(ComboBox cb, System.Windows.Forms.Label lbl)
        {
            // Si l'utilisateur a choisi une valeur de la liste
            if (cb.Text != "") { lbl.Text = ""; return true; }
            else //Sinon afficher un message d'erreur
            {
                lbl.ForeColor = Color.Red; lbl.Text = "Choisissez un type d'usager"; return false;
            }
        }

        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_prenom, b_nom, b_courriel, b_telephone, b_identification, b_combobox;
            //Appel de la méthode VerifierRegex pour tous les champs
            //Récupération des valeurs retournées dans les variables bouléennes
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{5,10}$", txtboxPrenom, lblErreurPrenom, "Lettre majuscule suivie de 5 à 15 lettres minuscules");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{5,10}$", txtboxNom, lblErreurNom, "Lettre majuscule suivie de 5 à 15 lettres minuscules");
            b_courriel = VerifierRegex(@"^[a-zA-Z0-9]{5,12}@[a-zA-Z0-9]{5,12}\.[a-zA-Z]{2,3}$", txtboxCourriel, lblErreurCourriel, "5 à 12 caractères alphanum +@+5 à 12 caractères alphanumériques+.+un mot de 2 ou 3 lettres");
            b_telephone = VerifierRegex(@"(^\(\d{3}\)\ \d{3}\-\d{4})$", txtboxNoTelephone, lblErreurNoTel, "(XXX) XXX-XXXX");
            b_identification = VerifierRegex("^[0-9]{5}$", txtNoIdentification, lblErreurNoIdentification, "Cinq chiffres");
            //Vérifier que l'utilisateur a sélectionné un type d'usager
            b_combobox = VerifierComboBox(comboBoxUsager, lblErreurCb);
            // Si toutes les vérifications sont valides retourner vrai
            if (b_prenom && b_nom && b_courriel && b_telephone
               && b_identification && b_combobox)
                return true;
            else return false; //Sinon retourner faux
        }
        public void InitialiserControles()
        {
            //Réinitialiser tous les champs du formulaire
            txtboxPrenom.Text = "";
            txtboxNom.Text = "";
            txtboxCourriel.Text = "";
            txtboxNoTelephone.Text = "";
            txtNoIdentification.Text = "";
            comboBoxUsager.SelectedIndex = -1; //Permet de réinitialiser la ComboBox
        }
        public void AfficherClient(Client c)
        {
            //Affiche un élécteur choisi par numéro d'élécteur
            //Initialiser les autres champs du formulaire aux attributs du client
            txtboxPrenom.Text = c.Prenom;
            txtboxNom.Text = c.Nom;
            txtboxCourriel.Text = c.Courriel;
            txtboxNoTelephone.Text = c.Telephone;
            txtNoIdentification.Text = c.NoIdentification;
            comboBoxUsager.Text = c.TypeUsager;

        }

        private void txtboxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (VerifierTous()) // Si tous les champs entrés sont valides
            {
                //Instancier un client avec les champs entrés par l'utilisateur
                Client cli = new Client(txtboxPrenom.Text, txtboxNom.Text, txtboxCourriel.Text, txtboxNoTelephone.Text, txtNoIdentification.Text, comboBoxUsager.Text);
                // Ajouter ce client au dictionnaire de la classe statique Client
                Client.AjouterClient(cli);
                InitialiserControles();     //Effacer les messages d'erreurs
            }
        }
        private void btnEmprunter_Click(object sender, EventArgs e)
        {

        }
        private void btnModifArticle_Click(object sender, EventArgs e)
        {
            //Pour s'assurer que tous les labels sont initialisés 
            InitialiserLabel();
            //Vérifier que le numéro entré correspond à un client
            bool b_identification = VerifierRegex("^[0-9]{5}$", txtNoIdentification, lblErreurNoIdentification, "5 chiffres");
            if (b_identification) //Si oui modifier le client
            {
                Client.ModifierClient(Client, client);
                InitialiserControles();
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Pour s'assurer que tous les labels sont initialisés 
            InitialiserLabel();
            //Vérifier que le numéro entré correspond à un client
            bool b_identification = VerifierRegex("^[0-9]{5}$", txtNoIdentification, lblErreurNoIdentification, "5 chiffres");
            if (b_identification) //Si oui supprimer le client
            {
                Client.SupprimerClient(int.Parse(txtNoIdentification.Text));
                InitialiserControles();
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            // Déterminer quels boutons sont disponnibles
            if (VerifierTous()) // Si tous les champs entrés sont valides
            {
                //SI usager est un client et passe les champs, permettre Emprunter, modifier client(le siens)
                // SINON SI usager est un responsable et passe les champs, permettre Ajouter client, Modifier client, Supprimer client

            }
        }

        private void btnModifierArticle_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutArticle_Click(object sender, EventArgs e)
        {

        }

        private void btnSupArticle_Click(object sender, EventArgs e)
        {

        }
    }
}
