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
            ConsoleView view = new ConsoleView();
            string ersteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlAlsString = view.HoleBenutzerEingabe("Bitte gib die zweite Zahl ein ein: ");
            string operation = view.HoleBenutzerEingabe("Bitte gib die auszuführende Operation an (+, -, * oder /): ");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe 
            view.GibResultatAus(model.Resultat, operation);
            view.HoleBenutzerEingabe("Zum beenden bitte Return drücken!");
        }

        
    }
}
