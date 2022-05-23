using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe48
{
    internal static class Program
    {
        private static double Gasverbrauch(double x, double y, double z) // Funktion
        {
            double rechner = (x * z) / (x * y); // (Liter * Preis) / (Liter * kWh pro Liter) = Preis pro kWh
            return rechner; // Return der Ausgabe zur Variable ausgabe
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Energiekostenrechner\n-------------------\nWie viel Liter Öl werden verbraucht?\n"); // Kopfzeile
            double liter = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            Console.WriteLine("\nWie viel kWh können aus einem Liter Öl gewonnen werden?"); // Abfrage für kWh pro Liter Öl
            double kWh = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            Console.WriteLine("\nWie viel kostet ein Liter Öl?"); // Abfrage für Preis pro Liter Öl
            double price = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            double ausgabe = Gasverbrauch(liter, kWh, price); // Abrufen der Funktion
            Console.WriteLine($"\nDie Energiekosten betragen: {ausgabe} Euro pro kWh.\nDrücken Sie eine beliebige Taste um das Programm zu beenden..."); // Ausgabe
            Console.ReadKey();
        }
    }
}
