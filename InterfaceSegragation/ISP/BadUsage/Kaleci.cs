using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation.ISP.BadUsage
{
    public class Kaleci : IFutbolcu
    {
        public void DefansYap()
        {
            //yapabilir
        }

        public void GolAt()
        {
            //yapabilir
        }

        public void PasAt()
        {
            //yapabilir
        }

        public void PenaltiyiKuratar()
        {
            //yapabilir
        }
    }
}
