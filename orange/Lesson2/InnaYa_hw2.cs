using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int a = 1; a <= 100; a++)
            {
                bool fizz = a % 3 == 0;
                bool buzz = a % 5 == 0;
                System.Threading.Thread.Sleep(1000);
                if (fizz && buzz) Console.WriteLine("FizzBuzz");
                    
                else if (fizz) Console.WriteLine("Fizz");

                else if (buzz) Console.WriteLine("Buzz");

                else Console.WriteLine(a);
            }
        }
    }
}
