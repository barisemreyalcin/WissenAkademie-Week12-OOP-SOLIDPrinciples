using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple
{
    public class DatabaseLog : DatabaseConnected
    {
        public override void CloseConnection()
        {
            //TODO : Close Databse Connection
            //TODO : Dispse Connection
        }

        public override void LogContent(string logMesasge)
        {
            OpenConnection();
            //TODO : Save logMessage to Database
            CloseConnection();
        }

        public override void OpenConnection()
        {
            //TODO : Create new instance or call connection from pool - cache

        }
    }
}
