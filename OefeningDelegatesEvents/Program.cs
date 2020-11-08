using System;

namespace OefeningDelegatesEvents
{
    public class Program
    {
        public enum ProductType { Tripel, Dubbel, Kriek, Pils }
        static void Main(string[] args)
        {
            Winkel w = new Winkel();
            Sales s = new Sales();
            w.Winkelverkoop += s.OnWinkelverkoop;

            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Dorpstraat 5, Lievegem"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 25, "Dorpstraat 5, Lievegem"));
            w.VerkoopProduct(new Bestelling(ProductType.Dubbel, 3.99, 35, "Kerkstraat 155, Zele"));
            w.VerkoopProduct(new Bestelling(ProductType.Kriek, 2.99, 55, "Dorpstraat 5, Lievegem"));

            s.ShowRapport();
        }
    }
}
