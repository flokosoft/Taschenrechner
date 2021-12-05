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
            string strRechenOperator = HoleRechenOperation("Wähle für\n+ = 1 \n- = 2");

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
                case "4":
                    Console.WriteLine("Diese Funktionen stehen blad zur verfügung");
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
    }
}
