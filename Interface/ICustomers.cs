using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ICustomers //interface 
    {
        void showtiming(); //method

        void printTicke();

    }
    public class silvercustomers : ICustomers //silvercust is impliment the interface after that wi can 
        //create a obj of the class 
    {
        public void printTicke()
        {
            Console.WriteLine("silvercustomers ; printTicke(); //method ");
        }
        //they both are method 
        public void showtiming()
       {
            Console.WriteLine("silvercustomers ; showtiming(); //method ");
       }
    }

    public class GoldCustomer : ICustomers
    {
        public void printTicke()
        {
            Console.WriteLine("goldcustomer ; printTicke(); //method");
        }
        //they both are method 
        public void showtiming()
        {
            Console.WriteLine("goldcustomer ; showtiming(); //method");
        }
    }
}
