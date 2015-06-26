using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    class ImportDuty :Tax
    {
        public override string Name
        {
            get { return "Import Duty"; }
             set { }
        }

        public override decimal Rate
        {
            get { return .05m; }
             set { }
        }

        public override decimal GetTax(decimal price)
        {
            decimal tax = Math.Ceiling((price * Rate) / .05m) * .05m;
            return tax;
        }
    }
}
