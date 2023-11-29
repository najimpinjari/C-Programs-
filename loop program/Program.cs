using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter yout number");
           /* int num = int.Parse(Console.ReadLine());

            for(int i = num-1; i>0; i--)
            {
                Console.WriteLine(i);
            }*/
           int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }

            }
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();






            Console.ReadLine();
        }
    }
}
