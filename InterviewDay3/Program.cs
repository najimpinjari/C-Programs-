using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDay3
{
    public class Program
    {
        public static bool Isprime( int num)
        {
            if (num <= 1) 
                return false;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    return false;
                }
                return true;

        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your number");
            int number = int.Parse(Console.ReadLine());

            if (Isprime(number))
            {
                Console.WriteLine($" {number} is a prime number ");

            }
            else
            {
                Console.WriteLine($" {number} is a not a prime number");
            }

            Console.ReadLine();
        }

       
    }
}
