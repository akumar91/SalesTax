using SalesTax.Billing;
using SalesTax.Products;
using SalesTax.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax.Shopping
{
    public class ShoppingStore
    {
        private ShoppingCart shoppingCart;
        private StoreShelf storeShelf;
        private PaymentCounter paymentCounter;
        private string country;

        public ShoppingStore()
        {
            country = "Local";
            shoppingCart = new ShoppingCart();
            paymentCounter = new PaymentCounter(country);
            storeShelf = new StoreShelf();
        }

        public void RetrieveOrderAndPlaceInCart(String name, double price, bool imported, int quantity)
        {
            Product product = storeShelf.SearchAndRetrieveItemFromShelf(name, price, imported, quantity);
            shoppingCart.AddItemToCart(product);
        }

        public void GetSalesOrder(int basket)
        {

            if (basket == 1) {
                IList<Input> basket1= new List<Input>() {
                new Input(){ Name="book", Price=12.49, Imported=false, Quantity=1},
                new Input(){ Name="music cd", Price=14.99, Imported=false, Quantity=1},
                new Input(){ Name="chocolate bar", Price=0.85, Imported=false, Quantity=1}
                };
                Console.WriteLine("***********INPUT********");
                Console.WriteLine("Shopping Basket1");
                foreach (Input prod in basket1)
                {
                    String name = prod.Name;
                    double price = prod.Price;
                    bool imported = prod.Imported;
                    int quantity = prod.Quantity;
                    String output = quantity.ToString() + " " + name + " at " + price.ToString();
                    Console.WriteLine(output);
                    RetrieveOrderAndPlaceInCart(name, price, imported, quantity);
                }
                Console.WriteLine("************************");
            }
            if (basket == 2)
            {
                IList<Input> basket2 = new List<Input>() {
                new Input(){ Name="box of chocolates", Price=10, Imported=true, Quantity=1},
                new Input(){ Name="bottle of perfume", Price=47.50, Imported=true, Quantity=1}
                };
                Console.WriteLine("***********INPUT********");
                Console.WriteLine("Shopping Basket2");
                foreach (Input prod in basket2)
                {
                    String name = prod.Name;
                    double price = prod.Price;
                    bool imported = prod.Imported;
                    int quantity = prod.Quantity;
                    String output = quantity.ToString() + " " + name + " at " + price.ToString();
                    Console.WriteLine(output);
                    RetrieveOrderAndPlaceInCart(name, price, imported, quantity);
                }
                Console.WriteLine("************************");
            }
            if (basket == 3)
            {
                IList<Input> basket2 = new List<Input>() {
                new Input(){ Name="bottle of perfume", Price=27.99, Imported=true, Quantity=1},
                new Input(){ Name="bottle of perfume", Price=18.99, Imported=false, Quantity=1},
                new Input(){ Name="packet of headache pills", Price=9.75, Imported=false, Quantity=1},
                new Input(){ Name="box of chocolates", Price=11.25, Imported=true, Quantity=1}
                };
                Console.WriteLine("***********INPUT********");
                Console.WriteLine("Shopping Basket3");
                foreach (Input prod in basket2)
                {
                    String name = prod.Name;
                    double price = prod.Price;
                    bool imported = prod.Imported;
                    int quantity = prod.Quantity;
                    String output = quantity.ToString() + " " + name + " at " + price.ToString();
                    Console.WriteLine(output);
                    RetrieveOrderAndPlaceInCart(name, price, imported, quantity);
                }
                Console.WriteLine("************************");
            }

        }

        public void CheckOut()
        {
            paymentCounter.BillItemsInCart(shoppingCart);
            Receipt receipt = paymentCounter.GetReceipt();
            paymentCounter.PrintReceipt(receipt);
        }

        public class Input
        {
            public double Price { get; set; }
            public string Name { get; set; }
            public bool Imported { get; set; }
            public int Quantity { get; set; }

        }
    }
}
