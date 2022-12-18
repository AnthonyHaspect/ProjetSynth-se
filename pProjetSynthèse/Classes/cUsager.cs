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
        public static int nb_usager = 0;// Tien Compte du nombre de Usager Créer   Référence mon Exercices d'Héritage avec les camion/véhicule/voiture
        public DateTime Datecreation;  //Date de la création de l'usager



        public cUsager(string nom, string prenom, DateTime datecreation)
        {
            nb_usager += 1;
            Nom = nom;
            Prenom = prenom;
            Datecreation = datecreation;
        }

        abstract public string Afficher();
    }
}
