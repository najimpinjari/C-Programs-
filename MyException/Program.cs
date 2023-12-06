using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("enter your number ");
            int j = int.Parse(Console.ReadLine());
            int result = 0;
            try
            {
                result = i / j;
            }
            catch (Exception e)
            {
                Console.WriteLine("divide by 0 is not allowed  ");
            }
            
            Console.WriteLine($"result is = : {result}");



            Console.ReadLine();
        }
    }
}
