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
        private cObjet cObjet;          //Classe objet qui contient les information de l'objet Choisit 
        private float itemTotal;        //Le nombre total d'item crée dans cette commande
        private cUsager cUsager;        //Classe Usager qui contient la personne qu¸i a fait la demande de 
        private float numCommandeId;    //Le numero unique de la demande de création
        public DateTime dateCommande;   //la date a la quelle elle a été Créee

        public float ItemTotal { get { return itemTotal; } set { itemTotal = value; } }
        public float NumCommandeId { get { return numCommandeId; } set { numCommandeId = value; } }
        public cUsager CUsager { get { return cUsager; } set { cUsager = value; } }
        public cObjet CObjet { get { return cObjet; } set { cObjet = value; } }

        public cCreation(float nbHeure, cObjet cObjet, float itemTotal, cUsager cUsager, float numCommandeId, DateTime dateCommande)
        {
            this.nbHeure = nbHeure;
            CObjet = cObjet;
            ItemTotal = itemTotal;
            CUsager = cUsager;
            NumCommandeId = numCommandeId;
            this.dateCommande = dateCommande;
        }


    }
}
