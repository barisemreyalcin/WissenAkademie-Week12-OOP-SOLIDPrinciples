using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragation
{
    public class RobotWork : IWork
    {
        public string Work()
        {
            return "Robot Work";
        }
    }
}
