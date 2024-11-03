using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple
{
    public abstract class DatabaseConnected : Log
    {
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
