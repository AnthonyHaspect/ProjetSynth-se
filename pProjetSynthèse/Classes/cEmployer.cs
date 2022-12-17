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

        public cEmployer(string nom, string prenom, DateTime dateTime, string numEmployer)
            : base(nom,prenom,dateTime)
        {
            NumEmployer= numEmployer;
        }

        public string NumEmployer { get { return numEmployer; } set { numEmployer = value; } }

        public override string Afficher()
        {
            return "Employer connecter : " + Prenom + " " + Nom + " Numero : " + numEmployer;
        }


    }
}
