
using static OefeningDelegatesEvents.Product;

namespace OefeningDelegatesEvents
{
    public class Voorraadbestelling
    {
        public ProductType Product { get; set; }
        public int Aantal { get; set; }

        public Voorraadbestelling(ProductType product, int aantal) {
            Product = product;
            Aantal = aantal;
        }

        public override string ToString()
        {
            return Product.ToString() +"," + Aantal;
        }
    }
}
