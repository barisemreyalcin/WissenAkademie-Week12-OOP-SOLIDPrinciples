using DependncyInversion.DIP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion.DIP.ValidUsage.Concrete
{
    public class Et : IUrun
    {
        public void YemekYap()
        {
            //TODO : Et pişirme talimatları
            Console.WriteLine("Et ürünü");
        }
    }
}
