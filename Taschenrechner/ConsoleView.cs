﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        private RechnerModel model;
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
            BenutzerWillBeenden = false;
        }

        public bool BenutzerWillBeenden { get; private set; }
        public bool ErneuteRechnung { get; private set; }

        public void HoleEingabenVonBenutzer()
        {
            if (!ErneuteRechnung)
            {
                model.ErsteZahl = HoleZahlVomBenutzer();
                model.RechenOperator = HoleOperatorVomBenutzer();
                model.ZweiteZahl = HoleZahlVomBenutzer();
                ErneuteRechnung = true;
            }
            else 
            {
                model.ErsteZahl = model.Ergebnis;
                model.ZweiteZahl = HoleZahlVomBenutzer();
            }

        }
        private double HoleZahlVomBenutzer()
        {
            string strEingabe;
            Console.Write("Bitte gib eine Zahl ein (Zum Beenden: Beenden): ");
            strEingabe = Console.ReadLine();
            if (strEingabe == "Beenden")
            {
                BenutzerWillBeenden = true;
                strEingabe = "0";
            }

            return Convert.ToDouble(strEingabe);
        }
        private string HoleOperatorVomBenutzer()
        {
            Console.WriteLine("Wähle für\n+ = 1 \n- = 2\n* = 3\n/ = 4");

            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum beenden bitte Enter drücken!");
            Console.ReadLine();
        }

        public void GebeWertAus()
        {
            switch (model.RechenOperator)
            {
                case "1":
                    Console.WriteLine("Die Summe ist: {0}", model.Ergebnis);
                    break;

                case "2":
                    Console.WriteLine("Die Differenz ist: {0}", model.Ergebnis);
                    break;

                case "3":
                    Console.WriteLine("Das Produkt ist: {0}", model.Ergebnis);
                    break;

                case "4":
                    Console.WriteLine("Der Quotient ist: {0}", model.Ergebnis);
                    break;


                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }

        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string strSummand = Console.ReadLine();

            return strSummand;
        }
    }
}
