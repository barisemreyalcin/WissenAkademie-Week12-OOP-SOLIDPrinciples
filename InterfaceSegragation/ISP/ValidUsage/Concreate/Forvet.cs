using InterfaceSegragation.ISP.BadUsage;
using InterfaceSegragation.ISP.ValidUsage.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFutbolcu = InterfaceSegragation.ISP.ValidUsage.Abstract.IFutbolcu;


namespace InterfaceSegragation.ISP.ValidUsage.Concreate
{
    public class Forvet : IFutbolcu, IForvet, IStoper
    {
        public void DefansYap()
        {
            Console.WriteLine("Forvet Defans Yap");
        }

        public void GolAt()
        {
            Console.WriteLine("Forvet Gol At");
        }

        public void PasAt()
        {
            Console.WriteLine("Forvet Pas At");
        }
    }
}
