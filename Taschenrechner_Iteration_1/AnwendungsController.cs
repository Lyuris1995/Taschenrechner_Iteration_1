using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
            double ersteZahl = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperatorVomBenutzer();
            double zweiteZahl = view.HoleZahlVomBenutzer();

            //Berechnung ausführen
            model.Berechne(ersteZahl, zweiteZahl, operation);

            // Ausgabe 
            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();

        }
    }
}

