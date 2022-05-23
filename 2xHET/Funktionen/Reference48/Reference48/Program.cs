using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference48
{
    internal static class Program
    {
        private static void Gasverbrauch(double x, double y, double z, ref double ausgabe) // Funktion
        {
            ausgabe = (x * z) / (x * y); // (Liter * Preis) / (Liter * kWh pro Liter) = Preis pro kWh
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Energiekostenrechner\n-------------------\nWie viel Liter Öl werden verbraucht?\n"); // Kopfzeile
            double liter = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            Console.WriteLine("\nWie viel kWh können aus einem Liter Öl gewonnen werden?"); // Abfrage für kWh pro Liter Öl
            double kWh = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            Console.WriteLine("\nWie viel kostet ein Liter Öl?"); // Abfrage für Preis pro Liter Öl
            double price = Convert.ToDouble(Console.ReadLine()); // Konvertieren auf Double

            double ausgabe = 0;
            Gasverbrauch(liter, kWh, price, ref ausgabe); // Abrufen der Funktion
            Console.WriteLine($"\nDie Energiekosten betragen: {ausgabe} Euro pro kWh.\nDrücken Sie eine beliebige Taste um das Programm zu beenden..."); // Ausgabe
            Console.ReadKey();
        }
    }
}
