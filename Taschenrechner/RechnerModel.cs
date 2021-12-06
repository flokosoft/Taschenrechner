using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Ergebnis { get; private set; }
        public string RechenOperator { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            RechenOperator = "unbekannt";
        }

        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        private double Subtrahieren(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }

        private double Multiplizieren(double ersterFaktor, double zweiterFaktor)
        {
            double dblProdukt = ersterFaktor * zweiterFaktor;

            return dblProdukt;
        }

        private double Dividieren(double dividend, double divisor)
        {
            double dblQuotient = dividend / divisor;

            return dblQuotient;
        }

        public void Berechne()
        {
            this.RechenOperator = RechenOperator;
            switch (RechenOperator)
            {
                case "1":
                    Ergebnis = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "2":
                    Ergebnis = Subtrahieren(ErsteZahl, ZweiteZahl);
                    break;

                case "3":
                    Ergebnis = Multiplizieren(ErsteZahl, ZweiteZahl);
                    break;

                case "4":
                    Ergebnis = Dividieren(ErsteZahl, ZweiteZahl);
                    break;

                default:
                    Ergebnis = 0;
                    break;
            }
        }
    }
}
