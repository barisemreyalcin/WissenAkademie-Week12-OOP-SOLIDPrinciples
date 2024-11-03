using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public class HibritDepoServisi : IDepoServisi, IYakitDepoServisi, IElektrikliDepoServisi
    {
        public void ArabayaBenzinAl(Araba araba)
        {
            if (araba.BenzinSeviyesi < 100)
                araba.BenzinSeviyesi = 100;
        }

        public void ArabayaBenzinAl(Araba araba, int benzinSeviyesi)
        {
            if (araba.BenzinSeviyesi < 100 && araba.BenzinSeviyesi > 0 && benzinSeviyesi <= (100 - araba.BenzinSeviyesi))
                araba.BenzinSeviyesi = benzinSeviyesi;
        }

        public bool DepoBosMu(Araba araba)
        {
            return (araba.ElektrikSeviyesi <= 0 && araba.BenzinSeviyesi <= 0);
        }


        public bool DepoDoluMu(Araba araba)
        {
            return (araba.ElektrikSeviyesi == 100 && araba.BenzinSeviyesi == 100);
        }

        public int ElektrikDepodaBosYeriVer(Araba araba)
        {
            return 100 - araba.ElektrikSeviyesi;
        }

        public Araba SarjEt(Araba araba)
        {
            araba.ElektrikSeviyesi = 100;
            return araba;
        }

        public Araba SarjEt(Araba araba, int seviye)
        {
            araba.ElektrikSeviyesi = seviye;
            return araba;
        }

        public int YakitDepodakiBosYeriVer(Araba araba)
        {
            return 100 - araba.BenzinSeviyesi;
        }
    }
}
