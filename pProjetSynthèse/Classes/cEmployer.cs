using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    internal class cEmployer : cUsager
    {
        private string numEmployer;
        //Référence mon Exercices d'Héritage avec les camion/véhicule/voiture pour l'héritage
        public cEmployer(string nom, string prenom, DateTime dateTime, string numEmployer)
            : base(nom,prenom,dateTime)
        {
            NumEmployer= numEmployer;
        }

        public string NumEmployer { get { return numEmployer; } set { numEmployer = value; } }

        public override string ToString()
        {
            string chaine = "";
            
            return chaine =string.Format("Employer connecter : {0}, {1}, Numero : {2}", Prenom, Nom, numEmployer);
        }

        public cEmployer()
        {
            NumEmployer= "NULL";
        }

    }
}
