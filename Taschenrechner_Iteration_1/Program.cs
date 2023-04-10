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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            AnwendungsController controller = new AnwendungsController(view, model);

            controller.Ausfuehren();
        }  
    }
}
