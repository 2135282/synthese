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
            if (e.Genre == 'f') // Si le genre est féminin cocher la radioButton1
                radioButton1.Checked = true;
            else radioButton2.Checked = true; // sinon cocher la radioButton2
            dateTimePicker1.Value = e.DateNaissance;//Initialiser le dateTimePicker à la date de naissance de l'électeur
            //Initialiser tous les autres champs du formulaire aux attributs de l'électeur
            textBox1.Text = e.NumeroElecteur.ToString();
            textBox2.Text = e.Telephone;
            textBox3.Text = e.Nom;
            textBox4.Text = e.Prenom;
            textBox5.Text = e.Adresse;
            textBox6.Text = e.Courriel;
            comboBox1.Text = e.Circonscription;

        }
    }
}
