using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLabraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to calculator application ");

            Calculator c1 = new Calculator();
            Console.WriteLine("Please enter first number  ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("enter yout second number");
            int second = int.Parse(Console.ReadLine());

            c1.add(first, second);

            Console.WriteLine("thank you for using calculator application ");

            Console.ReadLine();
        }
    }
}
