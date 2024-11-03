using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class MSSQLDatabase : IDatabase
    {
        //public void addDatabase(Employee employee)
        //{
        //    Console.WriteLine("Add Employee To MSSQL Database");
        //}
        public void AddDatabase(Employee emp)
        {
            if (!EmployeeExists(emp))
                InsertSQLDB(emp);
        }

        private bool EmployeeExists(Employee emp)
        {
            return false;
        }

        private void InsertSQLDB(Employee emp)
        {
            Console.WriteLine("Insert Employee MSSQL DB");
        }
    }
}
