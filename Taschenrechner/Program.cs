using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string strErsteZahlAlsString = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string strZweiteZahlAlsString = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            string strRechenOperator = HoleRechenOperation("Wähle für\n+ = 1 \n- = 2\n* = 3\n/ = 4");

            //Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double dblZahlEins = Convert.ToDouble(strErsteZahlAlsString);
            double dblZahlZwei = Convert.ToDouble(strZweiteZahlAlsString);

            double dblErgebnis = 0;
            //Berechnung ausführen 
            switch (strRechenOperator)
            {
                case "1":
                    dblErgebnis = Addiere(dblZahlEins, dblZahlZwei);
                    Console.WriteLine("Die Summe ist: {0}", dblErgebnis);
                    break;

                case "2":
                    dblErgebnis = Subtrahieren(dblZahlEins, dblZahlZwei);
                    Console.WriteLine("Die Differenz ist: {0}", dblErgebnis);
                    break;

                case "3":
                    dblErgebnis = Multiplizieren(dblZahlEins, dblZahlZwei);
                    Console.WriteLine("Das Produkt ist: {0}", dblErgebnis);
                    break;

                case "4":
                    dblErgebnis = Dividieren(dblZahlEins, dblZahlZwei);
                    Console.WriteLine("Der Quotient ist: {0}", dblErgebnis);
                    break;


                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

            //Ausgabe    
            HoleBenutzerEingabe("Zum beenden bitte Return drücken");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string strSummand = Console.ReadLine();

            return strSummand;
        }
        
        static string HoleRechenOperation(string frageNachOperator)
        {
            Console.WriteLine(frageNachOperator);
            string iOperator = Console.ReadLine();

            return iOperator;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static double Subtrahieren(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }

        static double Multiplizieren(double ersterFaktor, double zweiterFaktor)
        {
            double dblProdukt = ersterFaktor * zweiterFaktor;

            return dblProdukt;
        }

        static double Dividieren(double dividend, double divisor)
        {
            double dblQuotient = dividend / divisor;

            return dblQuotient;
        }
    }
}
