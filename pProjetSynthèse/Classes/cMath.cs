using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pProjetSynthèse.Classes
{
    //Devrait être static mais le Xunit n'aime pas le fait que c'est une static class donc elle doit etre normal
    public class cMath
    {
        //Retourne le total du prix de l'item + la taxe ensemble
        public static float CalculTaxes(float x)
        {
            float totalTaxer = (x * 15)/100 + x;
            return totalTaxer;
        }
        //retourne le total du profit donc le prix de vente - le cout de l'item
        public static float CalculProfit(float profit, float cout)
        {
            float Profit = profit - cout; 
            return Profit;
        }
    }
}
