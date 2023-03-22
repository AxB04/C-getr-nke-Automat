using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getränke_Automat
{
    public partial class Form1 : Form
    {
        Intelligenz computer = new Intelligenz(20, 4, 4, 4, 4);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            txt_ausgabe.Text = "";
            if(computer.bestellen(get_getränk(), get_menge()))
            {
                btn_bestellen.Enabled = false;
                txt_eingabe.Text = computer.getKosten().ToString();
            }
            else
            {
                MessageBox.Show(computer.getError(), "ein fehler ist aufgertreten");
            }
        }

        private void geld_eingezahlt(object sender, EventArgs e)
        {
            double geld = 0;
            if (sender == btn_10ct) geld = 0.1;
            else if (sender == btn_20ct) geld = 0.2;
            else if (sender == btn_50ct) geld = 0.5;
            else if (sender == btn_1eur) geld = 1;
            else geld = 2;

            if(computer.zahlen(geld))
            {
                btn_bestellen.Enabled = true;
                txt_eingabe.Text = "";
                txt_ausgabe.Text = computer.getWechselgeld().ToString();
            }
            else
            {
                txt_eingabe.Text = computer.getKosten().ToString();
            }
        }

        private int get_getränk()
        {
            if (rb_wasser.Checked) return 1;
            else if(rb_Apfelschorle.Checked) return 2;
            else if(rb_fanta.Checked) return 3;
            return 4;
        }

        private double get_menge()
        {
            if (rb_03.Checked) return 0.3;
            return 0.4;
        }
    }
}
