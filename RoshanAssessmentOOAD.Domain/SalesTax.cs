using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    class SalesTax :Tax
    {
        public override string Name
        {
            get { return "Basic Sales Tax"; }
             set { }
        }

        public override decimal Rate
        {
            get { return .10m; }
             set { }
        }

        public override decimal GetTax(decimal price)
        {
            decimal tax = Math.Ceiling((price * Rate) / .05m) * .05m;
            return tax; 
        }
    }
}
