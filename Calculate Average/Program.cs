using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements : ");
            int n = int.Parse(Console.ReadLine());

            double sum  = 0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter number {i + 1 }: ");
                double num = double .Parse(Console.ReadLine());
                sum += num;
            }
            double average = sum / n;
            Console.WriteLine($"Average : {average}");

        }
    }
}
