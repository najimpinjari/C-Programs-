using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_23_
{
    class Program
    {
        public void Show() //declaring a method // non-static method /instance method 
        {
            Console.WriteLine("hey rupesh whatsupp");
            Console.WriteLine("heey how are you doing");
        }
        public static void Show1() //declaring a method //static method 
        {
            Console.WriteLine("heey arbaz how are you");
            Console.WriteLine("hello");
        }

        public static void calculate(int a, int b)//paramiterised method with this mathod we can add 
            //parameter for perform some task to a method  
        {
            int c = a + b;
            Console.WriteLine($"  result of {a} +{b}  ="+c);
        }
        static void Main(string[] args)
        {
            
            Program.Show1 ();
            Program.Show1();
            Program.calculate(12, 1);
            //Program.calculate(1, 2);
            //Program.calculate(2, 3);
            //Program.calculate(3, 4);//we can call or use maltiple time one sileble method 

           // Program.Show1(); //when you want to call the static method that you have to use this 
            //type of syntax , first declare the class name then method name , no need of object creation
            //like non-static method 


            //Program p1 = new Program();
            //p1.Show(); //call mathod using p1 variable 
            //when you want call non static method that you must create a opject of an method  
            //Program p1 = new Program(); then you use p1 tag for call the method

            //Console.WriteLine("Enter your number");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter you second number");
            //int b = int.Parse(Console.ReadLine());

            //Program.calculate(a, b);



            Console.ReadKey();//for hold the console screen 
        }
    }
}
