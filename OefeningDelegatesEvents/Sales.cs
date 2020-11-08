using System;
using System.Collections.Generic;
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
        
        }
        public void ShowRapport()
        {
            Console.WriteLine("-----------");
            foreach (var item in rapport)
            {
                var value = item.Value;
            }
            Console.WriteLine("-----------");
        }
    }
}
