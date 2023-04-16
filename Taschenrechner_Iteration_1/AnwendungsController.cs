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
                view.HoleEingabenFuerErsteBerechnungVomBenutzer();

                model.Berechne();

                view.GibResultatAus();
                view.HoleEingabenFuerFortlaufendeBerechnung();

                while (!view.BenutzerWillBeenden)
                {
                    model.Berechne();
                    view.GibResultatAus();
                    view.HoleEingabenFuerFortlaufendeBerechnung();
                }
            }
        }
    }

