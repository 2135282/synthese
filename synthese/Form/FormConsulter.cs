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
    public partial class FormConsulter : Form
    {
        public FormConsulter()
        {
            InitializeComponent();
        }

        private void FormConsulter_Load(object sender, EventArgs e)
        {

        }

        // ** Exercices GestElection **
        // Devrait provenir d'une base de données SQL
        public void AfficherLivresListview(Livres l)
        {
            string[] arr = new string[8];
            ListViewItem itm;
            //Préparer les items dans un tableau
            arr[0] = l.Type;
            arr[1] = l.Titre;
            arr[2] = l.Quantite;
            arr[3] = l.pages;
            //Créer un ListViewItem
            itm = new ListViewItem(arr);
            //Ajouter la l'item ListViewItem à la listView1
            listView1.Items.Add(itm);
        }

        public void AfficherFilmsListview(Films f)
        {
            string[] arr = new string[8];
            ListViewItem itm;
            //Préparer les items dans un tableau
            arr[0] = f.Type;
            arr[1] = f.Titre;
            arr[2] = f.Quantite;
            arr[3] = f.DureeFilm;
            //Créer un ListViewItem
            itm = new ListViewItem(arr);
            //Ajouter la l'item ListViewItem à la listView1
            listView1.Items.Add(itm);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bool trouve = false;
            //Parcourir la liste des articles de la classe Articles pour afficher tous les articles du type choisi par l'utilisateur
            foreach (KeyValuePair<string, Articles> item in Articles.ListeArticles)
            {
                if (comboBox1.Text == "Livres") //Si l'article est inscrit dans le type livres
                {
                    AfficherLivresListview(item.Value); //Afficher les attributs des livres en question dans la listView1
                                                       // Noter que item.value correspond à l'objet Article dont le type correspond à Livres

                    trouve = true;
                }
                else if (comboBox1.Text == "Films")
                {
                    AfficherFilmsListview(item.Value); //Afficher les attributs des films en question dans la listView1
                                                       // Noter que item.value correspond à l'objet Article dont le type correspond à Films

                    trouve = true;
                }
            }
            if (trouve == false)// Si pas d'articles inscrits dans le type choisi par l'utilisateur
                MessageBox.Show("Il n'y a pas d'articles disponible de type: " + comboBox1.Text + " pour le moment", "Message");
        }
    }
}
