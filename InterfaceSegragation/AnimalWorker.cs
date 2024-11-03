using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class AnimalWorker : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Animal Work");
        }
    }
}
