using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Zeichen = "!§$%&/()=?{[]}'" + // Sonderzeichen
                             "0123456789" + // Zahlen
                             "abcdefghijklmnopqrstuvwxyz" + // Alphabet klein
                             "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Alphabet groß
            StringBuilder Text = new StringBuilder(); // String Zusammensetzung
            Random Zufall = new Random(); // Zufalls Generator
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++) // For Schleife
            {
                int Stelle = Zufall.Next(Zeichen.Length);
                Text.Append(Zeichen[Stelle]); // Zeichen am Ende des Strings anfügen
            }
            richTextBox1.Text = Text.ToString(); // Ausgabe
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); // Leeren
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Beenden
        }
    }
}
