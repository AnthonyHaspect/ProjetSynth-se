using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    internal class cGerant : cUsager
    {
        private string numGerant;

        public cGerant(string nom, string prenom, DateTime dateTime, string numGerant)
            : base(nom, prenom, dateTime)
        {
            NumGerant = numGerant;
        }

        public string NumGerant { get { return numGerant; } set { numGerant = value; } }

        public override string Afficher()
        {
            return "Gérant connecter : " + Prenom + " " + Nom + " Numero : " + numGerant;
        }

    }
}
