using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldautomat
{
    public partial class Form1 : Form
    {
        int Geld, Auswahl = 1;
        Rechner rechner = new Rechner();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        #region Groupbox1
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button7.Text = "Hinzufugen";
            label2.Text = "Hinzugefugt: " + Geld + "$";
            Auswahl = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button7.Text = "Auszahlen";
            label2.Text = "Ausgezahlt: " + Geld + "$";
            Auswahl = 2;
        }
  
        private void button7_Click(object sender, EventArgs e)
        {
            int AktuellerKontostand;
            bool hatGeld;
            (AktuellerKontostand, hatGeld) = rechner.KontoStand(Geld, Auswahl);
            if(hatGeld == true)
            {
                label1.Text = "Aktueller Kontostand: " + AktuellerKontostand;
            }
            else
            {
                label2.Text = "Ausgezahlt: " + AktuellerKontostand;
                MessageBox.Show("Ihr Konto konnte nicht den Vollen Betrag ausgeben!");
                label1.Text = "Aktueller Kontostand: 0";
            }
            Geld = 0;
            RefreshRad();
        }

        #endregion

        #region $$$
        
        private void button1_Click(object sender, EventArgs e)
        {
            //5
            Geld += 5;
            RefreshRad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //10
            Geld += 10;
            RefreshRad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //20
            Geld += 20;
            RefreshRad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //50
            Geld += 50;
            RefreshRad();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //100
            Geld += 100;
            RefreshRad();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //200
            Geld += 200;
            RefreshRad();
        }

        private void RefreshRad()
        {
            if(Auswahl == 1)
            {
                button7.Text = "Hinzufugen";
                label2.Text = "Hinzugefugt: " + Geld + "$";
            }
            else if(Auswahl == 2)
            {
                button7.Text = "Auszahlen";
                label2.Text = "Ausgezahlt: " + Geld + "$";
            }
        }

        #endregion

    }
}
