using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    internal class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
        }

        public void Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            // Berechnung ausführen
            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividieren(ersteZahl, zweiteZahl);
                    break;
            }
        }


        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }
        private double Subtrahiere(double minuend, double subtrahent)
        {
            double summe = minuend - subtrahent;

            return summe;
        }
        private double Multipliziere(double multiplikator, double multiplikand)
        {
            return multiplikator * multiplikand;
        }
        private double Dividieren(double dividend, double divisor)
        {
            return dividend / divisor;
        }
    }
}
