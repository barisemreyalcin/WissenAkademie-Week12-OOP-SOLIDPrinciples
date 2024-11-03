using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class HumanWorker : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Human Eat");
        }

        public void Pay()
        {
            Console.WriteLine("Human Pay");
        }

        public void Work()
        {
            Console.WriteLine("Human Work");
        }
    }
}
