using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Largest_of_Three_Numbers
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("largest of three numbers ");

            Console.WriteLine("enter the first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = Findlargestnumber (num1, num2, num3);

            Console.WriteLine($" the largest number is {largest}");

            Console.ReadLine();
        }
        static int Findlargestnumber(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b) , c);
        }

    }

}
