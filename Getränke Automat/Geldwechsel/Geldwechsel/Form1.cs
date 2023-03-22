using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldwechsel
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rechnen Automat = new Rechnen();

            double betrag = Convert.ToDouble(textBox1.Text);
                     
            listBox1.Items.Clear();
          
             if(betrag > 0)
             {

                string[] ausgabe =new string[Automat.wechseln(betrag).Length];
                ausgabe = Automat.wechseln(betrag);
                foreach (string a in ausgabe)
                { listBox1.Items.Add(a); }
                

             }
            else
            {
                listBox1.Items.Add("Bitte Packen sie geld in den Automat");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
