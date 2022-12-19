using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synthese.Class
{
    internal class Livres: Articles
    {
        //Champs privés
        private int noPages;

        //Accesseurs (propriétés)
        public int NumeroPages
        {
            get { return noPages; }
            set { noPages = value; }
        }

        //Constructeurs par défaut et avec paramètre
        public Livres()
        {
            noPages = 0;
        }

        public Livres(List<Articles> lstA, string titreArticle, int quantiteArticle, string typeArticle, int noP):
            base(lstA, titreArticle, quantiteArticle, typeArticle)
        {
            noPages = noP;
        }

        // Méthode surchargée dans la classe fille Livres
        // **Exercices GestElection**
        public override string[] ToArray()
        {
            //récuperer le tableau des proprietés de la classe parent Article
            string[] proprietes1 = base.ToArray();
            // créer un tableau pour acceuillir toutes les proprietés
            string[] proprietes = new string[proprietes1.Length + 1];
            // copier les proprietés héritées  
            proprietes1.CopyTo(proprietes, 0);
            // compléter le tableau proprietes avec les propriétés de la classe fille
            proprietes[proprietes1.Length] = noPages.ToString();
            return proprietes;
        }
    }
}
