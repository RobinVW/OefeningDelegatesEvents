using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningDelegatesEvents
{
    public class StockbeheerEventArgs : EventArgs
    {
        public Voorraadbestelling Bestelling { get; set; }

        public StockbeheerEventArgs(Voorraadbestelling bestelling)
        {
            Bestelling = bestelling;
        }
    }
}