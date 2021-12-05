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
            string strSummandEins = HoleSummanden("Bitte gib den ersten Summanden ein: ");
            string strSummandZwei = HoleSummanden("Bitte gib den zweiten Summanden ein: ");

            //Wandel Text in Gleitkommazahl
            double dblZahlEins = Convert.ToDouble(strSummandEins);
            double dblZahlZwei = Convert.ToDouble(strSummandZwei);

            //Berechnung ausführen 
            double dblSumme = Addiere(dblZahlEins, dblZahlZwei);


            //Ausgabe
            Console.WriteLine("Das Ergebnis beider Summanden lautet: {0}", dblSumme);
            WartenAufBenutzerEingabe();
        }

        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string strSummand = Console.ReadLine();

            return strSummand;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static void WartenAufBenutzerEingabe() //das ist eine Methode
        {
            Console.Write("Zum beenden bitte Return drücken");
            Console.ReadLine();
        }
    }
}
