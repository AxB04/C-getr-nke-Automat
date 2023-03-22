using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getraenkeautomat
{
    internal class Class
    {
        int Liter, Art;

        public Class()
        {

        }
        public double Preis(int aLiter, int aArt)
        {
            Art = aArt;
            Liter = aLiter;
            if (aLiter == 1)
            {
                if (aArt == 1) { return 0.6; }
                else if (aArt == 2) { return 0.9; }
                else if (aArt == 3) { return 1.2; }
                else if (aArt == 4) { return 1.2;  }
            }
            else if (aLiter == 2) 
            { 
                if (aArt == 1) { return 0.8; }
                else if (aArt == 2) { return 1.2; }
                else if (aArt == 3) { return 1.6; }
                else if (aArt == 4) { return 1.6; }
            }
            return 0;
        }
        public(double, int, int, int, int, int) Ruckgabe (double aGeld, double aPreis, int aApfelschorlensirup, int aFantasirup, int aColasirup, int akleineBecher, int agrosseBecher)
        {
            double Rechnung = 0;
            if (akleineBecher <= 0 && Liter ==1 || agrosseBecher <= 0 && Liter == 2) 
            {
                MessageBox.Show("Diese Bechergröße ist nicht mehr vorhanden!");
                Rechnung = aGeld;
            }
            else
            {
            if (aApfelschorlensirup <= 0 && Art == 2 || aColasirup <= 0 && Art == 4 || aFantasirup <= 0 && Art == 3) 
            {
                    MessageBox.Show("Dieses Getränk ist Ausverkauft!");
                    Rechnung = aGeld;
            }
            else 
            { 
            if (Liter == 1) { akleineBecher --; }
            else if (Liter == 2) { agrosseBecher --;}

            if (Art == 4) { aApfelschorlensirup --;}
            else if (Art == 2) { aFantasirup --;}
            else if (Art == 3) {  aColasirup --;}
                    Rechnung = (aPreis - aGeld) * -1;
            }
        }
        return (Rechnung, aApfelschorlensirup, aFantasirup, aColasirup, akleineBecher, agrosseBecher);
        }
    }
}
