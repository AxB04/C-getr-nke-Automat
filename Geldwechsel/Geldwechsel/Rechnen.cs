using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Geldwechsel
{
    internal class Rechnen
    {
        
        public string[] wechseln(double betrag)
        {
            
            double []type=new double[] { 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
            string carry = "";
            for (int i =0; i < type.Length; i++)
            {
                int münzenanzahl = 0;
                while(betrag >= type[i])
                {
                    münzenanzahl++;
                    betrag -= type[i] ;
                }
                if(münzenanzahl > 0) 
                {
                    carry += Convert.ToString(münzenanzahl + "mal die" + type[i] + "Münze\n");
                }
                

                
            }
            string[] ausgabe = new string[carry.Split('\n').Length];
            ausgabe = carry.Split('\n');
            return ausgabe;
        }
        
    }
}
