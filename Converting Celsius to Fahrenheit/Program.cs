using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, farenheit;

            Console.WriteLine("Enter tempreture in celcius ");
            celcius = double.Parse(Console.ReadLine());

            farenheit = (9.0 / 5.0) * celcius + 32 ;

            Console.WriteLine($"Tempreture in farenheit : {farenheit}, farenheit ");


            Console.ReadLine();
        }
    }
}
