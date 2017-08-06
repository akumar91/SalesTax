using SalesTax.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            // input for basket 1
            ShoppingStore basket1 = new ShoppingStore();
            basket1.GetSalesOrder(1);
            Console.WriteLine("***********OUTPUT********");
            basket1.CheckOut();
            Console.WriteLine("************************");

            // input for basket 2
            ShoppingStore basket2 = new ShoppingStore();
            basket2.GetSalesOrder(2);
            Console.WriteLine("***********OUTPUT********");
            basket2.CheckOut();
            Console.WriteLine("************************");

            // input for basket 3
            ShoppingStore basket3 = new ShoppingStore();
            basket3.GetSalesOrder(3);
            Console.WriteLine("***********OUTPUT********");
            basket3.CheckOut();
            Console.WriteLine("************************");

            Console.ReadKey();
        }
    }
}
