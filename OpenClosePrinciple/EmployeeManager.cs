using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class EmployeeManager
    {

        IDatabase db;

        public EmployeeManager(IDatabase _db)
        {
            this.db = _db;
        }


        public void addEmployee(Employee emp)
        {
            db.AddDatabase(emp);
        }

        //public void AddDatabase(string dbType,Employee emp)
        //{
        //    if(dbType == "MSSQL")
        //    {
        //        MSSQLDatabase db = new MSSQLDatabase();
        //        db.addDatabase(emp);
        //    }
        //    else if(dbType == "Oracle")
        //    {
        //        OracleDatabase oracle = new OracleDatabase();
        //        oracle.addDatabase(emp);
        //    }
        //    else if(dbType == "ELK")
        //    {
        //        //TODO : add employee to elastic searc db
        //    }
        //}
    }
}
