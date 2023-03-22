using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränke_Automat
{
    internal class Intelligenz
    {
        private int int_becher;
        private double int_wasser, int_apfelschorle, int_fanta, int_cola;
        private double int_kosten = 0;
        private int int_getränk = 0;
        private double int_menge = 0;
        private int int_error = 0;

        public Intelligenz(int becher, double wasser, double apfelschorle, double fanta, double cola)
        {
            int_becher = becher;
            int_wasser = wasser;
            int_apfelschorle = apfelschorle;
            int_fanta = fanta;
            int_cola = cola;
        }

        public Intelligenz()
        {
            int_becher = 20;
            int_wasser = 4;
            int_apfelschorle = 4;
            int_fanta = 4;
            int_cola = 4;
        }

        public bool bestellen(int getränk, double menge)
        {
            if (int_becher <= 0)
            {
                int_error = 3;
                return false;
            }
            switch(getränk)
            {
                case 1:
                    if (int_wasser < menge)
                    {
                        int_error = 1;
                        return false;
                    }
                    int_kosten = 2 * menge;
                    break;
                case 2:
                    if (int_apfelschorle < menge)
                    {
                        int_error = 1;
                        return false;
                    }
                    int_kosten = 3 * menge;
                    break;
                case 3:
                    if (int_fanta < menge)
                    {
                        int_error = 1;
                        return false;
                    }
                    int_kosten = 4 * menge;
                    break;
                case 4:
                    if (int_cola < menge)
                    {
                        int_error = 1;
                        return false;
                    }
                    int_kosten = 4 * menge;
                    break;
                default:
                    int_error = 2;
                    return false;
            }
            int_error = 0;
            int_getränk = getränk;
            return true;
        }

        public bool zahlen(double geld)
        {
            int_kosten -= geld;
            if (int_kosten <= 0)
            {
                return true;
            }
            return false;
        }

        public double getKosten()
        {
            return int_kosten;
        }

        public double getWechselgeld()
        {
            return int_kosten * -1;
        }

        public string getError()
        {
            switch(int_error)
            {
                case 0: return "kein fehler";
                case 1: return "nicht genügend getränke auf vorrat";
                case 2: return "dieses getränk ist nicht bekannt";
                case 3: return "nicht genügend Becher vorhanden";
                default: return "";
            }
        }
    }
}
