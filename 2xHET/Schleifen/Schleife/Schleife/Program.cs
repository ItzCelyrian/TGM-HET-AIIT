using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            int teiler = 0; // Alle wie viel Zeichen geteilt wird
            char zeichen; // Welches Zeichen ausgegeben wird
            char jn; // Soll das Programm wiederholt werden?

            Console.WriteLine("Symbolschreiber\n "); // Titel
            do // Do-Schleife für das Gesamte Programm welches für den char "jn" stimmt wenn er == 'J' ist.
            {
                // abstand Abfrage
                Console.WriteLine("Soll die Symbolkette mit untertrennung angezeigt werden? [J/N]");
                char abstand = Convert.ToChar(Console.ReadLine().ToUpper());

                // Abfrage ob der abstand eingeschalten ist
                if (abstand == 'J')
                {
                    // teiler Abfrage
                    Console.WriteLine("Jedes wie vielte Symbol soll getrennt werden?");
                    teiler = Convert.ToInt16(Console.ReadLine());
                }

                // zeichen Abfrage
                Console.WriteLine("Welches Symbol soll ausgegeben werden?");
                zeichen = Convert.ToChar(Console.ReadLine());

                // symbol Abfrage
                Console.Write("\nWie oft soll das Symbol ausgegeben werden?");
                int symbolnumber = Convert.ToInt16(Console.ReadLine()) + 1;
                for (int i = 1; i < symbolnumber; i++)
                {
                    Console.Write(zeichen);
                    if (abstand == 'J' && i % teiler == 0) // Statement für wenn Trennungen stattfinden und genug zeichen vorhanden sind für eine Unterteilung
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\nSoll der Prozess wiederholt werden? [J/N]: "); // Wiederholungsfrage
                jn = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (jn == 'J'); // Do-Schleifen Ende

            Console.WriteLine("Drücke eine bliebige Taste um das Programm zu beenden..."); // Programm Ende
            Console.ReadKey();
        }
    }
}
