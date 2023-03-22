﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getrankautomat
{
    internal class Intelligenz
    {
        int Liter, Art;

        public Intelligenz()
        {

        }

        public double Preis(int aLiter, int aArt)
        {
            Art = aArt;
            Liter = aLiter;
            if (aLiter == 1) //0,3L
            {
                if (aArt == 1) { return 0.6; } //Wasser
                else if (aArt == 2) { return 0.9; } //Apfelschorle
                else if (aArt == 3) { return 1.2; } //Fanta
                else if (aArt == 4) { return 1.2; } //Cola
            }
            else if (aLiter == 2) //0,4L
            {
                if (aArt == 1) { return 0.8; } //Wasser
                else if (aArt == 2) { return 1.2; } //Apfelschorle
                else if (aArt == 3) { return 1.6; } //Fanta
                else if (aArt == 4) { return 1.6; } //Cola
            }
            return 0; //(Standard)
        }

        public (double, int, int, int, int, int) Ruckgabe(double aGeld, double aPreis, int aApfelschorlensirup, int aFantasirup, int aColasirup, int akleineBecher, int agrosseBecher)
        {
            double Rechnung = 0;
            if (akleineBecher <= 0 && Liter == 1 || agrosseBecher <= 0 && Liter == 2)
            {
                MessageBox.Show("Diese Bechergrosse gibts nichtmehr!");
                Rechnung = aGeld;
            }
            else
            {
                if (aApfelschorlensirup <= 0 && Art == 2 || aColasirup <= 0 && Art == 4 || aFantasirup <= 0 && Art == 3)
                {
                    MessageBox.Show("Dieses Getrank gibts nichtmehr!");
                    Rechnung = aGeld;
                }
                else
                {
                    if (Liter == 1) { akleineBecher--; }
                    else if (Liter == 2) { agrosseBecher--; }

                    if (Art == 2) { aApfelschorlensirup--; }
                    else if (Art == 3) { aFantasirup--; }
                    else if (Art == 4) { aColasirup--; }
                    Rechnung = (aPreis - aGeld) * -1;
                }
            }
            return (Rechnung, aApfelschorlensirup, aFantasirup, aColasirup, akleineBecher, agrosseBecher);
        }
    }
}