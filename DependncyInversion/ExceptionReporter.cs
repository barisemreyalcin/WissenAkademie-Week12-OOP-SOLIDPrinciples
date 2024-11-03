using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion
{
    public class ExceptionReporter
    {
        private IDatabase database;

        public ExceptionReporter(IDatabase _database)
        {
            this.database = _database;
        }

        public void addException(Exception exception)
        {
            database.add(exception);
        }
    }
}
