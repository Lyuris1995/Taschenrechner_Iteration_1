using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    internal class RechnerModel
    {
        public double Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            // Berechnung ausführen
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    resultat = Dividieren(ersteZahl, zweiteZahl);
                    break;
            }
            return resultat;
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
