using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanAssessmentOOAD.Domain
{
    /// <summary>
    /// The  most important class that holds list of all the BasketItems in one basket.
    /// The main  purpose of this class is to produce the output reciept.
    /// </summary>
    public class Basket
    {
         private List<BasketItem> items;
        private decimal TotalTaxes;
        private decimal TotalProductPrice;

        public Basket()
        {
            items = new List<BasketItem>();
        }

        public void Add(BasketItem item)
        {
            this.items.Add(item);
        }

        public List<string> GenerateOutput()
        {
            List<string> output = new List<string>();
            foreach (var item in this.items)
            {
                decimal lineItemTaxes = item.GetTaxPerProduct() * item.Quantity;
                TotalTaxes += lineItemTaxes;
                decimal productPrice = item.Product.Price * item.Quantity;
                TotalProductPrice += productPrice;

                output.Add(string.Format("{0} {1} {2}", item.Quantity, item.Product.Name, productPrice + lineItemTaxes));
            }

            output.Add(string.Format("Sales Taxes: {0}", TotalTaxes));
            output.Add(string.Format("Total: {0}", TotalTaxes + TotalProductPrice));

            return output;

        }
    }

   
}
