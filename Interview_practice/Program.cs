using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_practice
{
    public  class Program
    {

        static void Main(string[] args)
        {
            //4. Reverse the String ‘Najim’
            //first 
            Console.WriteLine("enter String");

            string Name = Console.ReadLine();

            string rev = null;

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                rev += Name[i];
            }
            Console.WriteLine(rev);


            //second way 

            //Console.WriteLine("Enter Your String ");

            //string originalstring = Console.ReadLine();

            //char[] charArray = originalstring.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);

            //Console.WriteLine("Original String: " + originalstring);
            //Console.WriteLine("Reversed String: " + reversedString);

            Console.WriteLine("Enter your String");

            string ogstring = Console.ReadLine();

            char[] chararry = ogstring.ToCharArray();
            
            Array.Reverse(chararry);
            string revstring =  new string(chararry);

            Console.WriteLine($" og string = :{ogstring} ");
            Console.WriteLine($" rev string = :{revstring} ");







            Console.ReadLine();




        }
    }
}
