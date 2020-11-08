using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningDelegatesEvents
{
    public class Winkel
    {
        public event EventHandler<WinkelEventArgs> Winkelverkoop;
        public void VerkoopProduct(Bestelling p)
        {
            Console.WriteLine($"verkoopproduct - {p}");
            OnWinkelverkoop(p);
        }

        protected virtual void OnWinkelverkoop(Bestelling p)
        {
            Winkelverkoop?.Invoke(this, new WinkelEventArgs(p));
        }
    }
}
