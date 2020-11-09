using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using static OefeningDelegatesEvents.Program;

namespace OefeningDelegatesEvents
{
    class Stockbeheer
    {
        private Dictionary<ProductType, int> stock;
        public event EventHandler<StockbeheerEventArgs> Stockaankoop; 

        public Stockbeheer() {
            stock = new Dictionary<ProductType, int>();
            InitializeStock();
            
        }

        public void InitializeStock() {
            foreach (ProductType type in Enum.GetValues(typeof(ProductType)))
            {
                stock.Add(type, 100);
            }
        }

        public void OnWinkelverkoop(object source, WinkelEventArgs args)
        {
            stock[args.Bestelling.Product] -= args.Bestelling.Aantal;
            if (stock[args.Bestelling.Product] < 20) {
                BestelStock();
            }
        }

        public void BestelStock() {
            //lijst maken van de keys aangezien je de Dictionary niet kan aanpassen in een foreach loop
            var keys = new List<ProductType>(stock.Keys);
            foreach (ProductType product in keys) {
                //enkel bestelling plaatsen indien stock kleiner is dan 100
                if (stock[product] < 100) {
                    onVoorraadBestelling(new Voorraadbestelling(product, 100 - stock[product]));
                    stock[product] = 100;
                }
            }
        }

        protected virtual void onVoorraadBestelling(Voorraadbestelling voorraadbestelling)
        {
            Stockaankoop?.Invoke(this, new StockbeheerEventArgs(voorraadbestelling));
        }

        public override string ToString() {
            var str = "------------\n";
            foreach (KeyValuePair<ProductType, int> kvp in stock)
            {
                str += "[stock:"+kvp.Key+", "+kvp.Value+"]\n";
            }
            str += "------------";
            return str;
        }
    }
}
