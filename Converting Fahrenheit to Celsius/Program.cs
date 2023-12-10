using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Fahrenheit_to_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.WriteLine("Enter temperature in Fahrenheit:");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius: {0}", celsius);

            Console.ReadLine();
        }
    }
}
