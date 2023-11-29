using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_highest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]number = new int[] { 12, 45, 212, 566, 87, 1, 90 };

            int higest = 0;
            for(int i = 0; i < number.Length; i++)
            {
                for(int j =i+1; j< number.Length; j++)
                {
                    if (number[j] > higest)
                    {
                        higest = number[j];
                    }
                }
            }
            Console.WriteLine($" highest number ; {higest}");


           

            Console.ReadLine();
        }
    }
}
