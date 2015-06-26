using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    public class Medicine : Product
    {
        public override string Name
        {
            get;
            set;
        }

        public override decimal Price
        {
            get;
            set;
        }

        public override bool Imported
        {
            get;
            set;
        }

        public override bool TaxExempt
        {
            get { return true; }
            set { throw new NotImplementedException(); }
        }

        public Medicine(string Name, decimal Price, bool Imported)
        {
            this.Name = Name;
            this.Price = Price;
            this.Imported = Imported;
        }
    }
}
