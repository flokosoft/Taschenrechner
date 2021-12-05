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
            double flZahlEins = Convert.ToDouble(strZahlEins);
            double flZahlZwei = Convert.ToDouble(strZahlZwei);

            //Berechnung ausführen 
            double iSumme = flZahlEins + flZahlZwei;

            Console.WriteLine("Das Ergebnis beider Summanden lautet: {0}", iSumme);
            Console.ReadLine(); 
        }
    }
}
