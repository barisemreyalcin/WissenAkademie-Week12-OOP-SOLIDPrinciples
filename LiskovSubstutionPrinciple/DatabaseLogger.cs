using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple
{
    public class DatabaseLogger : Logger
    {
        public override void CloseConnection()
        {
            //TODO : Close Database Connection
            //TODO : Dispose Connection
        }

        public override void Log(string message)
        {
            //TODO : Create Log Content
            OpenConnection();
            //TODO : Save log content to Database
            CloseConnection();
        }

        public override void OpenConnection()
        {
            //TODO : Get Instance or get coonection pool item
            //TODO : Open Connection to database
        }
    }
}
