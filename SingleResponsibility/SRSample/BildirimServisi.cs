using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.SRSample
{
    public static class BildirimServisi
    {
        public static void YakitBildirim(int seviye)
        {
            Console.WriteLine($"Yeni Benzin Seviyesi : {seviye}");
        }

        public static void MotorBildirim(bool motorDurumu)
        {
            Console.WriteLine($"Motor : {(motorDurumu ? "çalıştırıldı" : "durduruldu")}");
        }

        public static void ArabanınDurumunuVer(Araba araba)
        {
            Console.WriteLine(araba.ToString());
        }
    }
}
