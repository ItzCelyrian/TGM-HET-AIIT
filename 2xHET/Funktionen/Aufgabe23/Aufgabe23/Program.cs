using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe23
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Freier Fall Rechner\nAus welcher Höhe fällt der Körper? (Höhe >= 0) [Meter]"); // Header
            double height = Convert.ToDouble(Console.ReadLine());
            double velocityKmh = FreeFallCalculator(height);
            Console.WriteLine($"Der Körper erreicht eine Höchstgeschwindigkeit von {velocityKmh} Km/h.\nDrücken Sie eine beliebige Taste um das Programm zu beenden..."); // Ausgabe & Ende
            Console.ReadKey();
        }

        static double FreeFallCalculator(double height) // Funktion
        {
            double velocityMs = (height * 9.81); // Rechnen der Höhe mal Erdbeschleunigung
            double ausgabe = (velocityMs * 3.6); // Umrechnen von m/s auf Km/h
            return ausgabe; // Ausgabe zurück an velocityKmh abgeben
        }
    }
}
