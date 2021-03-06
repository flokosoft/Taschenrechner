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

        public void Ausfuehren()
        {
            while (!view.BenutzerWillBeenden)
            {
                view.HoleEingabenVonBenutzer();
                model.Berechne();

                //Ausgabe
                view.GebeWertAus();
            }
            view.WarteAufEndeDurchBenutzer();
        }
    }
}
