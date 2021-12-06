using System;
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
        }

        public void HoleEingabenVonBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.RechenOperator = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }
        private double HoleZahlVomBenutzer()
        {
            Console.Write("Bitte gib die erste Zahl ein: ");

            return Convert.ToDouble(Console.ReadLine());
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
