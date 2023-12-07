using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string input  = Console.ReadLine(); 

            char[] charArry = input.ToCharArray();
            Array.Reverse(charArry);

            string Reverce = new string(charArry);
            Console.WriteLine($"reverce Array {Reverce}");

            Console.ReadLine();
        }
    }
}
