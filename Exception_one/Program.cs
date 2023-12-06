using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please enter numerator");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter denominator");
                int den = int.Parse(Console.ReadLine());

                Divide(num, den);
            }

          
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException : {ex.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"{ex.GetType().Name} {ex.Message}");
            }

            Console.WriteLine("thank you visit again");
            Console.ReadLine();
        }

        static void Divide(int num, int den)
        {
            //try
            //{
            try
            {
                int div = num / den;
                Console.WriteLine($"division ; {num} / {den} = {div}");
            }
            //catch(Exception e) { }
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //   Console.WriteLine(ex.StackTrace);
                // Console.WriteLine("dinomition cannot be zero enter the number greater thatn zero ");

                File.WriteAllText(@"Error\Error_handling.txt", $"{ex.Message} \n");
            }

            finally
            {
                Console.WriteLine("division opration completed ");

            }
        }
    }
}
