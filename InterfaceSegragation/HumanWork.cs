using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class HumanWork : IWork, IEatWork, IPayableWork
    {
        public string Eat()
        {
            return "Human Eat";
        }

        public string Pay()
        {
            return "Human Pay";
        }

        public string Work()
        {
            return "Human Work";
        }
    }
}
