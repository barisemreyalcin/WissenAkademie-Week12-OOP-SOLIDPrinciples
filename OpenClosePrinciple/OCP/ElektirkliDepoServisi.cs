using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.OCP
{
    public class ElektirkliDepoServisi : IDepoServisi, IElektrikliDepoServisi
    {
        public bool DepoBosMu(Araba araba)
        {
            return araba.ElektrikSeviyesi <= 0;
        }

        public int ElektrikDepodaBosYeriVer(Araba araba)
        {
            return 100 - araba.ElektrikSeviyesi;
        }

        public bool DepoDoluMu(Araba araba)
        {
            return araba.ElektrikSeviyesi == 100;
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
    }
}
