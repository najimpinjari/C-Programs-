using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_feb_24._1
{
    class Program
    {
        static void Main(string[] args)
        {   //optional methiod parameters 

            Total(10, 1);
            Total(20);
            
            Console.ReadLine();

        }
        static void Total(int a , int b = 5) //method using default parameter if we dont initializ value for b 
            // then he give a default value for itself
        {
            Console.WriteLine($" {a} + {b} = {a+b}");
        }
    }
}
