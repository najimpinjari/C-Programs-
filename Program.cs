using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Repeater
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("charector repited ");

            Console.WriteLine("Enter a charechter ");
            char charechter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter the number of time to repeat : ");
            int repeatcount = int.Parse(Console.ReadLine());

            string repeatedstring = Repeatcharector(charechter, repeatcount);

            Console.WriteLine($" result {repeatedstring}");

            Console.ReadLine();

        }
        static string Repeatcharector(char ch, int count)
        {
            return new string(ch, count);
        }
    }
  
}
