using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfueren()
        {
            double dblZahlEins = view.HoleZahlVomBenutzer();
            string strRechenOperator = view.HoleOperatorVomBenutzer();
            double dblZahlZwei = view.HoleZahlVomBenutzer();

            //Berechnung ausführen 

            model.Berechne(strRechenOperator, dblZahlEins, dblZahlZwei);

            //Ausgabe
            view.GebeWertAus();
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
