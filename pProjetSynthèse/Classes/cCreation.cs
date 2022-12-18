using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    internal class cCreation            //Demande de Création d'un objet
    {
        public float nbHeure;           //Nombre d'heure total que la commande va prendre a faire
        private string objet;          //Classe objet qui contient les information de l'objet Choisit 
        private float itemTotal;        //Le nombre total d'item crée dans cette commande
        private cUsager cUsager;        //Classe Usager qui contient la personne qu¸i a fait la demande de 
        private string numCommandeId;    //Le numero unique de la demande de création
        public DateTime dateCommande;   //la date a la quelle elle a été Créee

        public float ItemTotal { get { return itemTotal; } set { itemTotal = value; } }
        public string NumCommandeId { get { return numCommandeId; } set { numCommandeId = value; } }
        public cUsager CUsager { get { return cUsager; } set { cUsager = value; } }
        public string Objet { get { return objet; } set { objet = value; } }

        public cCreation(float nbHeure, string objet, float itemTotal, cUsager cUsager, string numCommandeId, DateTime dateCommande)
        {
            this.nbHeure = nbHeure;
            Objet = objet;
            ItemTotal = itemTotal;
            CUsager = cUsager;
            NumCommandeId = numCommandeId;
            this.dateCommande = dateCommande;
        }

        public cCreation()
        {
            nbHeure= 0;
            Objet= "NULL";
            ItemTotal= 0;
            CUsager = cUsager;
            numCommandeId = "C-NULL";
            dateCommande= DateTime.Now;
        }

        public string Affichage()
        {
            return "\nCommande : Numero: "+ numCommandeId;
        }


    }
}
