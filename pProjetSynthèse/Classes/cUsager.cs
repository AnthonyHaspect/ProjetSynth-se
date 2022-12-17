using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    internal class cUsager              //Va devenir soit un employer normal ou un Gérant
    {
        private string nom;             //Nom de l'usager
        private string prenom;          //Prenom de l'usager
        public  DateTime dateCreation;  //Date de la création de l'usager
        

        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }

        cUsager(string nom, string prenom, DateTime dateCreation)
        {
            Nom = nom;
            Prenom = prenom;
            this.dateCreation = dateCreation;
        }
    }
}
