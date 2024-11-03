using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple.ValidUsage
{
    public class Guvercin : Kus, IUc, IYuru
    {
        public override string Beslen()
        {
            return "Beslendi...";
        }

        public string Uc()
        {
            return "Uçtu...";
        }

        public string Yuru()
        {
            return "Yürüdü...";
        }
    }
}
