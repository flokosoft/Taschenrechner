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
            Console.Write("Bitte gib den ersten Summanden ein: ");
            string strZahlEins = Console.ReadLine();


            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string strZahlZwei = Console.ReadLine();

            //Wandel Text in Gleitkommazahl
            double dblZahlEins = Convert.ToDouble(strZahlEins);
            double dblZahlZwei = Convert.ToDouble(strZahlZwei);

            //Berechnung ausführen 
            double dblSumme = Addiere(dblZahlEins, dblZahlZwei);


            //Ausgabe
            Console.WriteLine("Das Ergebnis beider Summanden lautet: {0}", dblSumme);
            WartenAufBenutzerEingabe();
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
