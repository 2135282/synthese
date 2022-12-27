using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synthese.Class
{
    // ** Exercices Interface_ClassesMeres avec les animaux **
    internal class Livres : Articles, IDuree
    {
        // Implémenter la méthode Consomer() de l'interface IConsommer
        /// <summary>
        /// Calcule le temps d'un livre si le lecteur reste sur la même page environ 2min
        /// </summary>
        /// <returns>La durée de lecture d'un livre</returns>
        int DureeLecture()
        {
            return *2;
        }

        /// <summary>
        /// Implémenter la méthode abstraite de la classe Articles Consommer()
        /// </summary>
        public override void Consommer()
        {
            Console.WriteLine("Le client lit un livre.");
        }
    }
}
