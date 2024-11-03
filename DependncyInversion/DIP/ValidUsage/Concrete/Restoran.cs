using DependncyInversion.DIP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion.DIP.ValidUsage.Concrete
{
    public class Restoran
    {
        private readonly List<IUrun> yemekler;

        public Restoran (List<IUrun> yemekler)
        {
            this.yemekler = yemekler;
        }

        public void YemekYap()
        {
            foreach (var y in yemekler)
            {
                y.YemekYap();
            }
        }
    }
}
