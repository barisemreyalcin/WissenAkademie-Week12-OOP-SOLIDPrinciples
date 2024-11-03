using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class OracleDatabase : IDatabase
    {
        //public void addDatabase(Employee employee)
        //{
        //    Console.WriteLine("Add Employee To Oracle Database");
        //}
        public void AddDatabase(Employee emp)
        {
            InsertOracleDB(emp);
        }

        private void InsertOracleDB(Employee emp)
        {
            Console.WriteLine("Insert Employee Oracle DB");
        }
    }
}
