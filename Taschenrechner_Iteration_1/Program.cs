using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Taschenrechner_Iteration_1;

namespace Taschenrechner
{
    internal class Program
    {
        // METHODE DEFINIEREN (in 7 Schritten)
        // (optional) Modifizierer definieren
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Runde Klammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optional diese definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenrumpf schreiben)

        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein ein: ");
            string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation an (+, -, * oder /): ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            double resultat = model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe 
            GibResultatAus(resultat, operation);
            HoleBenutzerEingabe("Zum beenden bitte Return drücken!");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string Summand = Console.ReadLine();

            return Summand;
        }

        static void GibResultatAus(double resultat, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;

                case "*":
                    Console.WriteLine("Der Wert des Quotienten: {0}", resultat);
                    break;

                case "/":
                    Console.WriteLine("Das Produkt ist: {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl der Operation getroffen.");
                    break;
            }
        }
    }
}
