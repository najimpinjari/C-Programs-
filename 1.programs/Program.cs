using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Write a program that takes two numbers as input and prints their sum.

             Console.WriteLine("Please enter your number ");
             int first = int.Parse(Console.ReadLine());

             Console.WriteLine("please enter your second number");
             int second = int.Parse(Console.ReadLine()); 

             int sum = first + second;

             Console.WriteLine($" sum = {sum} ");



             //Create a program that calculates the average of three numbers.

             Console.WriteLine("enter yout fist number");
             double num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("enter yout second number");
             double num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("enter yout thired number");
             double num3 = Convert.ToDouble(Console.ReadLine());

             double avj = (num1 + num2 + num3) / 3;
             Console.WriteLine($" avj :  {avj}");


             //Write a program to determine if a given number is even or odd.

             Console.WriteLine("Please enter your number ");
             int number1 = Convert.ToInt32(Console.ReadLine());

             if (number1 % 2 == 0)
             {
                 Console.WriteLine("even");

             }
             else
             {
                 Console.WriteLine("odd");
             }
             


            //Create a program that calculates the factorial of a given number.

            Console.WriteLine("Please enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial of numbers is {factorial} ");




            Console.ReadLine();
        }
    }
}
