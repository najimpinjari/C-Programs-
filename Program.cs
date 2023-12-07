using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_continew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to calculator application");
            Console.WriteLine("please enter numearator");
            int  numerator , denominator ;

            if (int.TryParse(Console.ReadLine(), out numerator))
            {
                Console.WriteLine("please enter denominator");

                if (int.TryParse(Console.ReadLine(), out denominator))
                {
                    Divid(numerator , denominator);
                }
                else
                {
                    Console.WriteLine("Please enter a valid denominator");
                }
            }
            else
            {
                Console.WriteLine("please enter valid numar");
            }
            Console.WriteLine("Thank you visit again ");

            Console.ReadLine();
        }
        static void Divid(int num, int den)
        {
            if(den != 0)
            {
                int div = num / den;
                Console.WriteLine($"division {num} / {den} int {den}");
            }
            else
            {
                Console.WriteLine("denominator cannot be zero");
            }
          
            Console.WriteLine("division opretion completed");
        }

    }
   
}
