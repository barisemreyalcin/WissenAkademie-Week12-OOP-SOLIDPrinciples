using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion.DIP.BadUsage
{
    public class Restoran
    {
        Balık balik = new Balık();
        Tavuk tavuk = new Tavuk();

        public void YemekYap()
        {
            balik.BalikPisir();
            tavuk.TavukPisir();
        }
    }
}
