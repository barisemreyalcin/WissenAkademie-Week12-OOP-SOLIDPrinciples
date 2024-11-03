using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion
{
    public class ElasticSearch : IDatabase
    {
        public void add(Exception exception)
        {
            Console.WriteLine($"Info : {exception.Message} - {exception.InnerException} - {exception.StackTrace}");
        }
    }
}
