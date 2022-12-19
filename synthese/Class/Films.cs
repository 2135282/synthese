using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synthese.Class
{
    internal class Films: Articles
    {
        //Champs privés
        private int duree;

        //Accesseurs (propriétés)
        public int DureeFilm
        {
            get { return duree; }
            set { duree = value; }
        }

        //Constructeurs par défaut et avec paramètre
        public Films()
        {
            duree = 0;
        }

        public Films(List<Articles> lstA, string titreArticle, int quantiteArticle, string typeArticle, int dureeF) :
            base(lstA, titreArticle, quantiteArticle, typeArticle)
        {
            duree = dureeF;
        }

        /// <summary>
        /// Méthode surchargée dans la classe fille Films
        /// </summary>
        /// <returns>Les propriétés de la classe</returns>
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
            proprietes[proprietes1.Length] = duree.ToString();
            return proprietes;
        }
    }
}
