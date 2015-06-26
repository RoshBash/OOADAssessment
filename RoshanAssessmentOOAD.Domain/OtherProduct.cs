using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
   public class OtherProduct : Product
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
            get;
            set;
        }

        public OtherProduct(string Name, decimal Price,bool TaxExpemt, bool Imported)
        {
            this.Name = Name;
            this.Price = Price;
            this.Imported = Imported;
        }
    }
}
