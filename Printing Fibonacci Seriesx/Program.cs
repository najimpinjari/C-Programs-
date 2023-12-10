using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Fibonacci_Seriesx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;

            Console.WriteLine("Enter the number of terms : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("fibonacci series ; ");
            Console.WriteLine($" {0} {1}", a, b);

            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }

        }
    }
}
