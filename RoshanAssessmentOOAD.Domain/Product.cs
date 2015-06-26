using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    //Parent Class Product

   public abstract class Product
    {
      public abstract string Name { get; set; }
     public abstract  decimal Price { get; set; }
      public abstract bool Imported { get; set; }
      public abstract bool TaxExempt { get; set; }

    }
}
