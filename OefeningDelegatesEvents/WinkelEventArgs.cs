using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningDelegatesEvents
{
    public class WinkelEventArgs : EventArgs
    {
        public Bestelling Bestelling { get; set; }

        public WinkelEventArgs(Bestelling bestelling)
        {
            Bestelling = bestelling;
        }
    }
}
