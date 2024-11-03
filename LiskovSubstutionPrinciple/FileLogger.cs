using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple
{
    public class FileLogger : Logger
    {
        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void Log(string message)
        {
            //TODO : Open File Or Create File
            //TODO : Create Log Content
            //TODO : Save Log Content to File
            //TODO : Close File
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
