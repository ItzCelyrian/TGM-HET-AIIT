using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abfrage
            Console.WriteLine("Bitte wählen Sie Ihr Getränk:\nA - (E) Espresso\nB - (G) Großer Brauner\nC - (V) Verlängerter");
            // Eingabe auslesen
            string input = Console.ReadLine().ToUpper();

            if (input == "A" || input == "E" || input == "Espresso")
            {
                Console.WriteLine("Sie haben einen Espresso gewählt.\nGenießen Sie ihren Kaffee.");
                Console.ReadKey();
            }
            else
            {
                if (input == "B" || input == "G" || input == "Großer Brauner")
                { 
                    Console.WriteLine("Sie haben einen Großen Braunen gewählt.\nGenießen Sie ihren Kaffee.");
                    Console.ReadKey();
                }
                else
                {
                    if (input == "C" || input == "V" || input == "Verlängerter")
                    {
                        Console.WriteLine("Sie haben einen Verlängerten gewählt.\nGenießen Sie ihren Kaffee.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Ihre Eingabe war ungültig.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
