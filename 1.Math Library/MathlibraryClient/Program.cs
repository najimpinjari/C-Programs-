using _1.Math_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathlibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculatr application ");

            Calculator c1 = new Calculator();
            Console.WriteLine("please enter yout first number");
            int first = int.Parse(Console.ReadLine());  

            Calculator c2 = new Calculator();
            Console.WriteLine("please enter your second number");
            int second = int.Parse(Console.ReadLine());

            c1.add(first, second);

            Console.WriteLine("thnak you for using calculaltor application ");              


            Console.ReadLine();
        }
    }
}
