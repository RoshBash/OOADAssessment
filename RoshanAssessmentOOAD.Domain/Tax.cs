using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    //Public abstract class Tax which  acts as a parent class for
    //Sales tax and Import Duty 
   public abstract class Tax
    {
       public abstract string Name { get; set; }
      public abstract decimal Rate { get; set; }
      public abstract decimal GetTax(decimal price);
    }
}
