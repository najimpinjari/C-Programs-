using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive__Negative__or_Zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("posiitve , nigative or zero cheker");

            Console.WriteLine("please enter your number");
            int number = int.Parse(Console.ReadLine());

            if(number > 0)
            {
                Console.WriteLine($" {number} is positive ");
            }
            else if(number < 0)
            {
                Console.WriteLine($"{number} is niaative");
            }
            else
            {
                Console.WriteLine($" {number} is zero");
            }

            Console.ReadKey();
        }
    }
}
