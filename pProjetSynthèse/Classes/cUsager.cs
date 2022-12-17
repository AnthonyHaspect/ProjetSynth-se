using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    abstract class cUsager              //Va devenir soit un employer normal ou un Gérant
    {
        public string Nom;             //Nom de l'usager
        public string Prenom;          //Prenom de l'usager
        public DateTime Datecreation;  //Date de la création de l'usager



        public cUsager(string nom, string prenom, DateTime datecreation)
        {
            Nom = nom;
            Prenom = prenom;
            Datecreation = datecreation;
        }

        abstract public string Afficher();
    }
}
