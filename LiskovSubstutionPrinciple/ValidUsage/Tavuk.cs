using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple.ValidUsage
{
    public class Tavuk : Kus, IYuru
    {
        public override string Beslen()
        {
            return "Beslendi...";
        }

        public string Yuru()
        {
            return "Yürüdü....";
        }
    }
}
