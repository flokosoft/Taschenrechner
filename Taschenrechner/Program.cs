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
            int iRechenOperator = HoleRechenOperation("Wähle für\n+ = 1 \n- = 2");

            //Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double dblZahlEins = Convert.ToDouble(strErsteZahlAlsString);
            double dblZahlZwei = Convert.ToDouble(strZweiteZahlAlsString);

            double dblErgebnis = 0;
            //Berechnung ausführen 
            if (iRechenOperator == 1)
            {
                dblErgebnis = Addiere(dblZahlEins, dblZahlZwei);
            }
            else
            {
                dblErgebnis = Subtrahieren(dblZahlEins, dblZahlZwei);
            }
            

            //Ausgabe
            Console.WriteLine("Das Ergebnis beider Zahlen lautet: {0}", dblErgebnis);
            HoleBenutzerEingabe("Zum beenden bitte Return drücken");
        }

        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string strSummand = Console.ReadLine();

            return strSummand;
        }
        
        static int HoleRechenOperation(string frageNachOperator)
        {
            Console.WriteLine(frageNachOperator);
            int iOperator = Convert.ToInt16(Console.ReadLine());

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
