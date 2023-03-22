using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getraenkeautomat
{
    public partial class Form1 : Form
    {
        int Liter, Art, Apferschorlensirup = 10, Fantasirup = 10, Colasirup = 10, kleineBecher = 10, grosseBecher = 10;
        double Geld, Preis, Ruckgeld;
        Class Intelligenz = new Class ();

        private void PreisAusgabe() 
        {
            Preis = Math.Round(Intelligenz.Preis(Liter, Art), 2);
            label1.Text = "Preis: " + Convert.ToString(Preis) + "Euro";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Art = 1;
            PreisAusgabe();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Art = 2;
            PreisAusgabe();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Art = 3;
            PreisAusgabe();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Art = 4;
            PreisAusgabe();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Liter = 1;
            PreisAusgabe();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Liter = 2;
            PreisAusgabe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Geld != 0 && Preis != 0)
            {
                (Ruckgeld, Apferschorlensirup, Fantasirup, Colasirup, kleineBecher, grosseBecher) = Intelligenz.Ruckgabe(Geld, Preis, Apferschorlensirup, Fantasirup, Colasirup, kleineBecher, grosseBecher);
                Ruckgeld = Math.Round(Ruckgeld, 2);
                if (Ruckgeld < 0)
                {
                    MessageBox.Show("Bitte fugen Sie mehr Geld hinzu!");
                }
                else
                {
                    label2.Text = "Ruckgeld: " + Convert.ToString(Ruckgeld) + " Euro";
                    label4.Text = "Apfelschorlen Sirup " + Convert.ToString(Apferschorlensirup);
                    label5.Text = "Fanta Sirup " + Convert.ToString(Fantasirup);
                    label6.Text = "Cola Sirup " + Convert.ToString(Colasirup);
                    label7.Text = "0,3 L " + Convert.ToString(kleineBecher);
                    label8.Text = "0,4 L " + Convert.ToString(grosseBecher);

                    Ruckgeld = 0;
                    Geld = 0;
                    Preis = 0;
                    label3.Text = "Geld Input: ";
                    radioButton1.Checked = true;
                    radioButton5.Checked = true;
                }
            }
            else
            { MessageBox.Show("Bitte Getrank auswahlen oder Geld hinzufugen!"); }
        }    
        private void button2_Click(object sender, EventArgs e)
            {
            Geld += 0.1;
            Auszahlung();
            }
        private void button3_Click(object sender, EventArgs e)
        {
            Geld += 0.2;
            Auszahlung();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Geld += 0.5;
            Auszahlung();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Geld += 1;
            Auszahlung();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Geld += 2;
            Auszahlung();
        }

        private void Auszahlung()
        {
            label3.Text = "Geld Input: " + Math.Round(Geld, 2);
        }
    }
}

