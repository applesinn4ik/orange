using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnaYa
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;

            do
            {
                Console.WriteLine("Hello, my dear friend. Enter the first number");
                string value1 = Console.ReadLine();
                x = Convert.ToInt32(value1);

                Console.WriteLine("Thanks, now enter the second number");
                string value2 = Console.ReadLine();
                y = Convert.ToInt32(value2);
                z = x % y;

                if (z == 0) Console.WriteLine("Well done, take a candy!");
                else Console.WriteLine("Try again, no candies today :(");
            }
            while (z != 0);

            Console.ReadLine();
        }
    }
}
