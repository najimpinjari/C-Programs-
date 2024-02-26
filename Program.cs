using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_fab._26
{
    class Program
    {
        static void Main(string[] args) // calling method 
       {
            //   int a = 11;

            //    PrintA( ref a);
            //    Console.WriteLine(a);
            int d;
            PrintC(out d);
            Console.WriteLine(d);

        Console.ReadLine();
        }

        static void PrintA( ref int b )  //called method 
        {
           // b = 1000;
        }

        static void PrintC(out int d)
        {
            d = 200;
        }


    }
}




