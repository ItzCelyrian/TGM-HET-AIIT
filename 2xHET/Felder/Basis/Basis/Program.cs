using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nRundungsprüfer\n------------------\n\nGeben sie eine Zahl ein:"); // Titel
            int Eingabe = Convert.ToInt32(Console.ReadLine()) % 10; // % 10 um die Letzte Zahl der Nummerstelle zu erhalten
            int[] zahlenFeld = { 5, 6, 7, 8, 9 }; // Array mit Aufrundungszahlen

            bool check = InhaltPruefer(Eingabe, zahlenFeld); // Check Funktion
            if (check == false)
            {
                Console.WriteLine("\nIhre Zahl wird abgerundet.\nDrücken Sie eine beliebige Taste um das Programm zu beenden...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nIhre Zahl wird aufgerundet.\nDrücken Sie eine beliebige Taste um das Programm zu beenden...");
                Console.ReadKey();
            }
        }

        static bool InhaltPruefer(int z, int[] F) //Abfragen ob sich eine Zahl X in einem Array befindet.
        {
            bool jn = false; //Standardmäßig wird jn (Ja/Nein) auf Falsch gesetzt.
            for (int i = 0; i < F.Length; i++) //Diese Schleife wiederholt sich so oft, wie das Array Stellen hat.
            {
                if (z == F[i]) //Überprüfung ob die Zahl an der momentanen Stelle die gesuchte ist.
                {
                    jn = true; //Setzen von jn (Ja/Nein) auf Richtig (Übereinstimmung)
                }
            }
            return jn; //jn (Ja/Nein) an das Überprogramm zurückgeben.
        }
    }
}
