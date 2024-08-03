using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Practive_day2
{
    public class Program
    {
        //   Method overloading
        public void Display()
        {
            Console.WriteLine("display method with no parameter ");
        }

        public void Display( string message )
        {
            Console.WriteLine("display method with string");
        }

        public void Display( int result )
        {
            Console.WriteLine("display method with intiger");
        }


        //method hiding 
        public class BaseClass
        {
            public void show()
            {
                Console.WriteLine("show method in base class");
            }
        }

        public class dereveClass : BaseClass
        {
            public void show()
            {
                Console.WriteLine("show method in derived class ");
            }
        }

        static void Main(string[] args) //main method entry point of every program 
        {
            //4.    Method overloading, Method hiding scenarios?  Write the output with reason


            Program program = new Program();
            program.Display();      //display method with no parameter
            program.Display("Najim");   //display method with string
            program.Display(24);        //display method with intiger


            //// Method hiding

            BaseClass baseClass = new BaseClass();
            baseClass.show();              //show method in base class

            dereveClass dereveClass = new dereveClass();
            dereveClass.show();           //show method in derived class

            BaseClass obj = new dereveClass();
            obj.show();                 //show method in base class


            //data type converntion is nothing but converting one datatype to another datatype 
            //implicit conversion compiler automatic does the convertion 
            //and explicit conversion manually we have to do conversion 
            //converting small datatype to large datatype is typ conversion 
            //dif way to converiosn explicit as follow 

            //type casting 

            float a = 10;
            int b = (int)a;

            console.writeline(a);

            ////using of convert class

            float d = 10;
            int c = Convert.ToInt32(d);

            Console.WriteLine(d);

            ////using as keyword 
            object e = "software enginner";
            string s = e as string;

            Console.WriteLine(s);

            //cast oprator 

            int num = 123;
            double t = (double)num; Console.WriteLine(t);

            object num1 = "123";
            string str1 = (string)num1; Console.WriteLine(str1);


            //convert class
            string number = "123";
            int num3 = Convert.ToInt32(number); Console.WriteLine(number);

            double num4 = 123.01;
            string str = Convert.ToString(num4); Console.WriteLine(num4);


            string num2 = "123";
            int number = int.Parse(num2);

            Console.WriteLine(number);

            string num = "abc";
            try
            {
                int num22 = int.Parse(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("invalid format +" + ex.Message);
            }

            string validnumber = "12333";
            if (int.TryParse(validnumber, out int number))
            {
                Console.WriteLine("converting success " + number);
            }
            else
            {
                Console.WriteLine("conversion failed ");
            }


            string invalidnumber = "abc";
            if (int.TryParse(invalidnumber, out int number2))
            {
                Console.WriteLine("converting success " + number2);
            }
            else
            {
                Console.WriteLine("conversion failed");
            }



            //boxing //unboxing 

            //boxing                //converting values type to ref types 
            int i = 11;
            object s = i;
            Console.WriteLine(s);

            //unboxing              //converting ref type to values types 
            object v = 12377;
            int e = (int)v;

            //Console.WriteLine(e);


            var s = "3fsawafg";  // no need of datatype its atomatic asume that datatypes 
                                 //  var k = null; //compiltime error 
                                 //used like a local varibale we cant user like a global variable 
                                 //the main resong to intruducing var keyword is introdusing annanumas types in cshaprt 


            var person = new { id = 1, name = "najim" };  //anonymouse anonymouse method or types 
            Console.WriteLine(person);





            Console.ReadLine();
        }
    }
}
