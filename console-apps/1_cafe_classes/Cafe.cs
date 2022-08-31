using System;
using Cafe.Drinks;

namespace Cafe
{
    class Program
    {
        static void Main()
        {
            //front-end logic
            Coffee order = new Coffee("black coffee", 5, 6);

            Coffee.Deals();

            Console.WriteLine("The name is: " + order.Name);  // "black coffee"
            Console.WriteLine("The Price is: " + order.Price);
            Console.WriteLine("The Size is : " + order.Size);

            order.SizeUp(); // 20

            Console.WriteLine("Actually, the price is: " + order.Price);

        }
    }
}

