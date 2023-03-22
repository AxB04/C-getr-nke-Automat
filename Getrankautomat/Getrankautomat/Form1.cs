namespace Getrankautomat
{
    public partial class Form1 : Form
    {
        int Liter, Art, Apfelschorlensirup = 10, Fantasirup = 10, Colasirup = 10, kleineBecher = 10, grosseBecher = 10;
        double Geld, Preis, Ruckgeld;
        Intelligenz intelligenz = new Intelligenz();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region CheckedCanged
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

        private void PreisAusgabe()
        {
            Preis = Math.Round(intelligenz.Preis(Liter, Art), 2);
            label6.Text = "Preis: " + Convert.ToString(Preis) + " Euro";
        }
        #endregion
        private void button6_Click(object sender, EventArgs e)
        {           
            if (Geld != 0 && Preis < Geld)
            {
                (Ruckgeld, Apfelschorlensirup, Fantasirup, Colasirup, kleineBecher, grosseBecher) = intelligenz.Ruckgabe(Geld, Preis, Apfelschorlensirup, Fantasirup, Colasirup, kleineBecher, grosseBecher);  
                Ruckgeld = Math.Round(Ruckgeld, 2);
                if (Ruckgeld < 0)
                {
                    MessageBox.Show("Bitte fugen Sie mehr Geld hinzu!");
                }
                else
                {
                    label7.Text = "Ruckgeld: " + Convert.ToString(Ruckgeld) + " Euro";
                    label2.Text = "Apfelschorlen Sirup: " + Convert.ToString(Apfelschorlensirup);
                    label3.Text = "Fanta Sirup: " + Convert.ToString(Fantasirup);
                    label4.Text = "Cola Sirup: " + Convert.ToString(Colasirup);
                    label5.Text = "0,3 Becher: " + Convert.ToString(kleineBecher);
                    label8.Text = "0,4 Becher: " + Convert.ToString(grosseBecher);

                    Ruckgeld = 0;
                    Geld = 0;
                    label1.Text = "Geld Input: ";
                }
            }
            else { MessageBox.Show("Bitte Getrank auswahlen oder Geld hinzufugen!"); }
        }

        #region Geld hinzufugen
        private void button1_Click(object sender, EventArgs e)
        {
            Geld += 0.1;
            Auszahlung();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Geld += 0.2;
            Auszahlung();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Geld += 0.5;
            Auszahlung();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Geld += 1;
            Auszahlung();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Geld += 2;
            Auszahlung();
        }

        private void Auszahlung()
        {
            label1.Text = "Geld Input: " + Math.Round(Geld, 2);
        }
        #endregion
    }
}