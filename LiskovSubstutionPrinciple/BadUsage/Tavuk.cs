using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstutionPrinciple.BadUsage
{
    public class Tavuk : Kus
    {
        public override string Beslen()
        {
            return "Beslendi..";
        }

        public override string Uc()
        {
            throw new NotImplementedException();
        }

        public override string Yuru()
        {
            return "Yürüdü...";
        }
    }
}
