﻿using System;
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

            //Wandel Text in Ganzzahl
            int iZahlEins = Convert.ToInt32(strZahlEins);
            int iZahlZwei = Convert.ToInt32(strZahlZwei);

            //Berechnung ausführen
            int iSumme = iZahlEins + iZahlZwei;

            Console.WriteLine("Das Ergebnis beider Summanden lautet: {0}", iSumme);
            Console.ReadLine(); 
        }
    }
}
