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
        //Référence mon Exercices d'Héritage avec les camion/véhicule/voiture pour l'héritage
        public cGerant(string nom, string prenom, DateTime dateTime, string numGerant)
            : base(nom, prenom, dateTime)
        {
            NumGerant = numGerant;
        }

        public string NumGerant { get { return numGerant; } set { numGerant = value; } }

        public override string ToString()
        {
            string chaine = "";

            return chaine = string.Format("\nGérant connecter : {0}, {1}, Numero : {2}", Prenom, Nom, numGerant);
        }

        public cGerant()
        {
            numGerant = "NULL";
        }

    }
}
