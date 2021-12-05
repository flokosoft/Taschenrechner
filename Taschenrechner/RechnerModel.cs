using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double dblErgebnis { get; private set; }
        public string RechenOperator { get; private set; }

        public RechnerModel()
        {
            dblErgebnis = 0;
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

        public void Berechne(string strRechenOperator, double ersteZahl, double zweiteZahl)
        {
            this.RechenOperator = strRechenOperator;
            switch (strRechenOperator)
            {
                case "1":
                    dblErgebnis = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "2":
                    dblErgebnis = Subtrahieren(ersteZahl, zweiteZahl);
                    break;

                case "3":
                    dblErgebnis = Multiplizieren(ersteZahl, zweiteZahl);
                    break;

                case "4":
                    dblErgebnis = Dividieren(ersteZahl, zweiteZahl);
                    break;

                default:
                    dblErgebnis = 0;
                    break;
            }
        }
    }
}
