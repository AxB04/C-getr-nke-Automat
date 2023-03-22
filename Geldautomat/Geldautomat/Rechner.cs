using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geldautomat
{
    internal class Rechner
    {
        int AktuellerKontoStand = 0;

        public (int, bool) KontoStand(int aGeld, int aAuswahl)
        {
            bool aistGeld = true;
            if(aAuswahl == 1) //Wenn Geld hinzugefugt werden soll
            {
                AktuellerKontoStand += aGeld;
                aistGeld = true;
            }
            else if(aAuswahl == 2) //Wenn Geld ausgezahlt werden soll
            {
                AktuellerKontoStand -= aGeld;
                if(AktuellerKontoStand < 0)
                {
                    AktuellerKontoStand = aGeld - (AktuellerKontoStand * (- 1));
                    aistGeld = false;
                }
                else
                {
                    aistGeld = true;
                }
            }
            return (AktuellerKontoStand, aistGeld);
        }
    }
}
