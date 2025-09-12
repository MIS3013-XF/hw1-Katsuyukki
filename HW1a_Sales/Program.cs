// HW1a Sales Total

// Your Name: Sami Youef
// Did you seek help ? If yes, specify the helper or web link here:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Salestaxrate = 0.085;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            string Item = Console.ReadLine();

            Console.WriteLine($"How many {Item}'s do you want to buy?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price for each Football Ticket?");
            double price = Convert.ToDouble(Console.ReadLine());

            double subtotal = quantity * price;
            double salesTax = subtotal * Salestaxrate;
            double total = subtotal + salesTax;
            
            Console.WriteLine($"\nYour Subtotal for your bill {subtotal:C2}");
            Console.WriteLine($"Your sales tax for your bill {salesTax:C2}");
            Console.WriteLine($"Your total for your bill is {total:C2}");
                
            Console.ReadKey();
        }
    }
}
