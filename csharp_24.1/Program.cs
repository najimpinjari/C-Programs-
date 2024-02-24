using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_24._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            Console.WriteLine(a);
            PrintValue(ref a);
            Console.WriteLine(a);

            Console.ReadKey();


        }

        static void PrintValue( ref int b )
        {
            b = 100;
        }

    }
}
