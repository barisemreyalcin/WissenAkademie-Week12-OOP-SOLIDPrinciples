using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class AnimalWork : IWork, IEatWork
    {
        public string Eat()
        {
            return "Animal Eat";
        }

        public string Work()
        {
            return "Animal Work";
        }
    }
}
