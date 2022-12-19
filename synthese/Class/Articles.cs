using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synthese.Class
{
    internal class Articles
    {
        //Attributs
        public List<Articles> listeArticles;    //  la liste des articles
        private string titre;
        private int quantite;
        private string type;

        //Propriétés
        public List<Articles> ListeArticles
        {
            get { return this.listeArticles; }
            set { this.listeArticles = value;}
        }
        public string Titre
        {
            get { return this.titre; }
            set { this.titre = value; }
        }
        public int Quantite
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //Constructeur par défaut
        public Articles()
        {
            listeArticles = new List<Articles>();
            titre = "";
            quantite = 0;
            type = "";
        }

        //Constructeur par paramètres
        public Articles(List<Articles> lstA, string titreArticle, int quantiteArticle, string typeArticle)
        {
            {
                listeArticles = lstA;
                titre = titreArticle;
                quantite = quantiteArticle;
                type = typeArticle;
            } 
        }

        // Méthode qui retourne un tableau contenant les différentes valeurs des attributs
        //Cette méthode sera surchargée dans la classe Livre
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[7];
            proprietes[0] = type;
            proprietes[1] = titre;
            proprietes[2] = quantite.ToString();
            return proprietes;
        }
    }
}
