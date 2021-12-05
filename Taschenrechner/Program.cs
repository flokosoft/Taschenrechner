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

            //Berechnung ausführen 
            RechnerModel model = new RechnerModel();
            double dblErgebnis = model.Berechne(strRechenOperator, dblZahlEins, dblZahlZwei);

            //Ausgabe    
            GebeWertAus(strRechenOperator, dblErgebnis);
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



        static void GebeWertAus(string RechenOperator, double Ergebnis)
        {
            switch (RechenOperator)
            {
                case "1":
                    Console.WriteLine("Die Summe ist: {0}", Ergebnis);
                    break;

                case "2":
                    Console.WriteLine("Die Differenz ist: {0}", Ergebnis);
                    break;

                case "3":
                    Console.WriteLine("Das Produkt ist: {0}", Ergebnis);
                    break;

                case "4":
                    Console.WriteLine("Der Quotient ist: {0}", Ergebnis);
                    break;


                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }
    }
}
