using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    public class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }

        public void Berechne()
        {
             switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividieren(ErsteZahl, ZweiteZahl);
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
