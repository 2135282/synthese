using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synthese.Class
{
    // *** Classe Statique ***
    internal class Comparaison
    {
        // Méthode statique
        /// <summary>
        /// Calcule si le nb de livres empruntés est égal au nb de films empruntés
        /// </summary>
        /// <param name="nbLivres">Le nb de livres loués</param>
        /// <param name="nbFilms">Le nb de films loués</param>
        /// <returns>True si le nb est égal ou False si le nb n'est pas égal</returns>
        public static bool Egalite(Client nbLivres, Client nbFilms)
        {
            if (nbLivres == nbFilms))
                    return true;
            else
                return false;
        }
    }
}
