using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class RobotWorker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
