using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input from user 
            Console.WriteLine("Enter your number");
            
            
                int number = int.Parse(Console.ReadLine());

            
            //check divisibility by 3 and 5 
            if(number % 3  == 0 &&  number % 5 ==0) 
            {
                Console.WriteLine("ThreeFive");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Three");
            }
            else if (number % 5 == 0) 
            {
                Console.WriteLine("five");
            }
            else
            {
                Console.WriteLine("The Entered Number is not divisibale 3 and 5");
            }


        }
    }
}
