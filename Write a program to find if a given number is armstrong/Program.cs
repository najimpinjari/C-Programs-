using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_a_program_to_find_if_a_given_number_is_armstrong
{
    internal class Program
    {
       
            static void Main()
            {
                Console.Write("Enter a number to check for Armstrong: ");
                int number = int.Parse(Console.ReadLine());

                if (IsArmstrong(number))
                {
                    Console.WriteLine($"{number} is an Armstrong number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not an Armstrong number.");
                }
            }

            static bool IsArmstrong(int number)
            {
                int originalNumber = number;
                int numDigits = CountDigits(number);
                int sum = 0;

                while (number > 0)
                {
                    int digit = number % 10;
                    sum += (int)Math.Pow(digit, numDigits);
                    number /= 10;
                }

                return sum == originalNumber;
            }

            static int CountDigits(int number)
            {
                int count = 0;
                while (number != 0)
                {
                    number /= 10;
                    count++;
                }
                return count;
            }
        





    }
}

