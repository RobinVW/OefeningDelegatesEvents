using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningDelegatesEvents
{
    public class Groothandelaar
    {
        private List<Voorraadbestelling> bestellingenLijst;

        public Groothandelaar() {
            bestellingenLijst = new List<Voorraadbestelling>();
        }

        public void onVoorraadBestelling(object source, StockbeheerEventArgs args) {
            bestellingenLijst.Add(args.Bestelling);
        }

        public void ShowBestellingen() {
            Console.WriteLine("-----------");
            foreach (Voorraadbestelling bestelling in bestellingenLijst) {
                Console.WriteLine("Voorraadbestelling : " + bestelling.ToString());
            }
            Console.WriteLine("-----------");
        }
    }
}
