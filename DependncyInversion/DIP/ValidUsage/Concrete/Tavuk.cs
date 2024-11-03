using DependncyInversion.DIP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion.DIP.ValidUsage.Concrete
{
    public class Tavuk : IUrun
    {
        public void YemekYap()
        {
            //TODO : Tavuk pişirme talimatları
            Console.WriteLine("Tavuk ürünü");
        }
    }
}
