using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoshanAssessmentOOAD.Domain;

namespace RoshanAssessmentOOAD
{
    class Program
    {
        static void Main(string[] args)
        {

            // Basket 1  
            Basket cart = new Basket();
            cart.Add(new BasketItem(new Book("Book", 12.49m, false), 1));
            cart.Add(new BasketItem(new OtherProduct("Music CD", 14.99m, false, false),1));
            cart.Add(new BasketItem(new Food("Chocolate Bar", .85m, false), 1));


            foreach (var line in cart.GenerateOutput())
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            // Basket 2
            Basket cart2 = new Basket();
            cart2.Add(new BasketItem(new Food("Imported Box of Chocolates", 10.00m, true), 1));
            cart2.Add(new BasketItem(new OtherProduct("Imported Bottle of Perfume", 47.50m, false, true), 1));


            foreach (var line in cart2.GenerateOutput())
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();


            //Basket 3
            Basket cart3 = new Basket();
            cart3.Add(new BasketItem(new OtherProduct("Imported Bottle of Perfume", 27.99m, false, true), 1));
            cart3.Add(new BasketItem(new OtherProduct("Bottle of Perfume", 18.99m, false, false), 1));
            cart3.Add(new BasketItem(new Medicine("Packet of Headache pills", 9.75m, false), 1));
            cart3.Add(new BasketItem(new Food("Imported Box of Chocolates", 11.25m, true), 1));


            foreach (var line in cart3.GenerateOutput())
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
