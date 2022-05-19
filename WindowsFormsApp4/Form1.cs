using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            int slovapocet = 0;
            int cifry = 0;
            int pismena = 0;
            int minuly = 0;
            string nejdelsislovo = "";
            string cisla = "0 1 2 3 4 5 6 7 8 9";
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz ěščřžýáíéůú";
            bool chyba = false;
            try
            {
                textBox2.Text = vstup.Substring(0, vstup.Length / 2) + vstup.Last() + vstup.Substring(vstup.Length / 2);
            }
            catch
            {

                MessageBox.Show("Zadej text do 1. textboxu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chyba = true;
            }
           
           
            vstup = vstup.Trim();
            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
            vstup = vstup.ToLower();
            string[] slova = vstup.Split(' ');


            foreach (string slovo in slova)
            {
                slovapocet++;
                foreach (char cifra in slovo)
                {
                    if (cisla.Contains(cifra))
                    {
                        cifry++;
                    }
                    if (abecedniZnaky.Contains(cifra))
                    {
                        pismena++;
                    }

                }
                if (slovo.Length > minuly)
                {
                    minuly = slovo.Length;
                    nejdelsislovo = slovo;
                }
            }
            if(chyba == true)
            {
                slovapocet = 0;
            }
            label6.Text = "Počet slov: " + slovapocet;
            label2.Text = "Počet cifer: " + cifry;
            label3.Text = "Počet písmen: " + pismena;
            label4.Text = "Nejdelší slovo: " + nejdelsislovo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
