using synthese.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synthese
{
    // *** Recherche ou statistique = recherche par critère: Recherche par Type + Titre
    public partial class FormConsulter : Form
    {
        public FormConsulter()
        {
            InitializeComponent();
        }

        private void FormConsulter_Load(object sender, EventArgs e)
        {
            //Instancier un objet Article qui sera utilisé pour se connecter à la base de données 
            //et y accéder
            Articles Art = new Articles();

            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Articles;";

            // Préparer l'objet Command en mettant dans la CommandText la chaîne Query préparée
            Art.Command.CommandText = Query;

            // Mettre dans la propriété Connection de l'objet Command l'objet Connection qu'on a 
            // Préparé (Instancié)
            Art.Command.Connection = Art.Connection;

            // Préparer l'objet Adapter qui sert d'intermédiaire entre la source de données et
            // le DataSet. SelectCommand est utilisée car notre commande est une commande
            // Select
            Art.Adapter.SelectCommand = Art.Command;

            //Remplir le DataSet Ado.DsScolarite avec le résultat de la requête Query (Dans ce 
            //cas le résultat est la table Etudiants). Pour cela il faut utiliser la méthode 
            //Fill
            Art.Adapter.Fill(Art.DsArticles);

            // La requête retourne une seule table. On met ce résultat dans la DataTable DtArticles
            Art.DtProjetSynthese = Art.DsArticles.Tables[0];

            // Afficher la table Art.DsArticles dans notre dataGridView: il suffit d'associer
            // la table obtenue Art.DsArticles au DataSource de notre dataGridView
            this.dataGridView1.DataSource = Art.DsArticles;
        }

        // ** Laboratoire_Mode_deconnecte **
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes du DataTable DtProjetSynthese
            Articles Art = new Articles();
            foreach (DataRow row in Art.DtProjetSynthese.Rows)
            {
                //Si le titre existe dans la table, Afficher les informations de l'article dans un MessageBox.
                if (row[2].ToString() == textBoxTitre.Text)
                    MessageBox.Show("Le type d'article :  " + row[4] + "\n"
                                      + "Le titre : " + row[2] + "\n"
                                      + "La quantité en stock : " + row[3] + "\n"
                                      + "Le nombre de pages (livre) : " + row[0] + "\n"
                                      + "La durée (film) : " + row[1] + "\n", "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
