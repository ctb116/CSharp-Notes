using System;
using System.Collections.Generic;
using Cafe.Drinks;

namespace Cafe
{
    class Program
    {
        static void Main()
        {
            Coffee order = new Coffee("Cathy", 4, 16);

            Console.WriteLine(order.Name);
            Console.WriteLine(order.Size);
            order.Size = 65;

            Console.WriteLine("What's the price of a coffee?");
            Console.WriteLine(order.GetPrice());
            Console.WriteLine("Would you like to order?");
        }
    }
}

