using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Sources;

namespace OefeningDelegatesEvents
{
    public class Sales
    {
        private Dictionary<string, List<Bestelling>> rapport;
        public Sales() {
            rapport = new Dictionary<string, List<Bestelling>>();
        }
        public void OnWinkelverkoop(object source, WinkelEventArgs args) {
            if (rapport.ContainsKey(args.Bestelling.Adres)) {
                var value = rapport[args.Bestelling.Adres];
                //value.Add(args.Bestelling);
                var obj = value.FirstOrDefault(x => x.Product == args.Bestelling.Product);
                if (obj != null)
                {
                    obj.Aantal += args.Bestelling.Aantal;
                }
                else {
                    value.Add(args.Bestelling);
                }
            }
            else
            {
                List<Bestelling> bestellingsList = new List<Bestelling>();
                bestellingsList.Add(args.Bestelling);
                rapport.Add(args.Bestelling.Adres, bestellingsList);
            }
        }
        public void ShowRapport()
        {
            Console.WriteLine("-----------");
            foreach (var pair in rapport)
            {
                Console.WriteLine(pair.Key);
                foreach (Bestelling bestelling in pair.Value) {
                    Console.WriteLine("   " + bestelling.ToString());
                }
            }
            Console.WriteLine("-----------");
        }
    }
}
