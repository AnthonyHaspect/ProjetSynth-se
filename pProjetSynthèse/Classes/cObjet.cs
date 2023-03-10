using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    public class cObjet           //Classe qui possède les informations sur les objets    
    {
        private int nbParHeure;   //Nombre d'objet crée par heure(ex: 100)
        private float prix;         //Le prix au quelle l'objet se vend(prix de vente)(ex: 
        private float cout;         //Le coût de l'item a produire par heure (matériaux/ Main d'oeuvre)(ex: 12500$)
        private string idObjet;      //Id unique de l'objet pour l'identifié (code barre)(ex: 843543
        private string nomObjet;    //Nom descriptif de l'objet (ex: Telephone)

        public int NbParHeure { get { return nbParHeure; } set { nbParHeure = value; } }
        public float Prix { get { return prix; } set { prix = value; } }
        public float Cout { get { return cout; } set { cout = value; } }
        public string IdObjet { get { return idObjet; } set { idObjet = value; } }
        public string NomObjet { get { return nomObjet; } set { nomObjet = value; } }

        public cObjet(int nbParHeure, float prix, float cout, string idObjet, string nomObjet)
        {
            NbParHeure = nbParHeure;
            Prix = prix;
            Cout = cout;
            IdObjet = idObjet;
            NomObjet = nomObjet;
        }

        public cObjet()
        {
            nbParHeure = 0;
            Prix = 0;
            Cout= 0;
            idObjet = "I-objet";
            nomObjet = "objet";
        }

        /// <summary>
        /// Cette fonction permet de calculer le prix d'un item individuel
        /// </summary>
        /// <param name="calculcout"></param> est la valeur cout 
        /// <param name="CalculnbParHeure"></param> est la valeur nbParHeure
        /// <returns></returns> retourne le nombre 
        public float calculerPrixParItem(float calculcout, float CalculnbParHeure)
        {
            return (calculcout / CalculnbParHeure);
        }

    }
}
