using System;

namespace OefeningDelegatesEvents
{
    public class Program
    {
        public enum ProductType { Dubbel, Kriek, Pils, Tripel }
        static void Main(string[] args)
        {
            Winkel w = new Winkel();
            Sales s = new Sales();
            Stockbeheer sb = new Stockbeheer();
            Groothandelaar gh = new Groothandelaar();
            Console.WriteLine(sb.ToString());
            w.Winkelverkoop += s.OnWinkelverkoop;
            w.Winkelverkoop += sb.OnWinkelverkoop;

            sb.Stockaankoop += gh.onVoorraadBestelling;

            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Dorpstraat 5, Lievegem"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 25, "Dorpstraat 5, Lievegem"));
            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Kerkstraat 155, Zele"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 55, "Dorpstraat 5, Lievegem"));

            s.ShowRapport();
            Console.WriteLine(sb.ToString());

            sb.BestelStock();
            gh.ShowBestellingen();
            Console.WriteLine(sb.ToString());



        }
    }
}
