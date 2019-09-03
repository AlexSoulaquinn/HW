using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTotal_Quinn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alex Quinn
            //Declare Variables
            string purchaseItemAsString, purchaseQuantityAsString, itemPriceAsString, subtotalAsString, totalSalesTaxAsString, totalAsString;
            double purchaseQuantity, itemPrice, subtotal, totalSalesTax, total;
            const double salesTax = .085;

            //Gather input from User
            Console.WriteLine("What is the product name of item you are purchasing?");
            purchaseItemAsString = Console.ReadLine();
            Console.WriteLine("How many " + purchaseItemAsString + "'s do you want to buy?");
            purchaseQuantityAsString = Console.ReadLine();
            Console.WriteLine("What is the price of each " + purchaseItemAsString + "?");
            itemPriceAsString = Console.ReadLine();

            //Convert string
            purchaseQuantity = Convert.ToDouble(purchaseQuantityAsString);
            itemPrice = Convert.ToDouble(itemPriceAsString);

            //Calculate subtotal, sales tax, and total
            subtotal = purchaseQuantity * itemPrice;
            totalSalesTax = subtotal * salesTax;
            total = totalSalesTax + subtotal;

            //Convert doubles to strings
            subtotalAsString = subtotal.ToString("C2");
            totalSalesTaxAsString = totalSalesTax.ToString("C2");
            totalAsString = total.ToString("C2");

            //Output to user
            Console.WriteLine("Your subtotal for your bill is " + subtotalAsString);
            Console.WriteLine("Your sales tax for your bill is " + totalSalesTaxAsString);
            Console.WriteLine("Your total for your bill is " + totalAsString);
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }
    }
}
