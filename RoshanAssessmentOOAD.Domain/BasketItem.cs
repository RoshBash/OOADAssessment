using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    ///<summary>
    ///BasketItem Class provides the Tax for the Product based upon the type of product.    /// 
    /// </summary>
    
  public  class BasketItem
    {
        public Product Product  { get; private set; }
        public List<Tax> Taxes { get; private set; }
        public int Quantity { get; set; }
        public BasketItem(Product Product, int Quantity)
        {
            this.Product = Product;
            this.Taxes = new List<Tax>();
            this.Quantity = Quantity;

            if(!Product.TaxExempt) //Checking  if  the product is exempt from the Taxes or not
            {
                Taxes.Add(new SalesTax());
            }
            
            if(Product.Imported) // Checking if the product is imported or not
            {
                Taxes.Add(new ImportDuty());
            }
        }
        /// <summary>
        /// Gets amount of tax on the product.  
        /// </summary>
        /// <returns>The amount of tax on the product.  It does not consider quantity</returns>
        public decimal GetTaxPerProduct()
        {
            decimal total = 0;

            foreach(var tax in Taxes)
            {
                total += tax.GetTax(Product.Price);
            }
            return total;
        }

    }
}
