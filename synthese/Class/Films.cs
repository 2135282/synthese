using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synthese.Class
{
    // ** Exercices Interface_ClassesMeres avec les animaux **
    internal class Films : Articles
    {
        /// <summary>
        /// Implémenter la méthode abstraite de la classe Articles Consommer()
        /// </summary>
        public override void Consommer()
        {
            Console.WriteLine("Le client écoute un film.");
        }
    }
}
