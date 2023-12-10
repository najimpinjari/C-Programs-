using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Enter first number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");


            Console.ReadLine();           
        }
    }
}
