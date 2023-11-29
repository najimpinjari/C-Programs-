using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Icustomer c1 = new ICustomer(); //not possible 
            /*
                        ICustomers c1  = new silvercustomers();
                        c1.showtiming(); //callin method 
                        c1.printTicke();

                        c1 = new GoldCustomer();
                        c1.showtiming();//calling method
                        c1.printTicke();  

                        silvercustomers sc = new silvercustomers();
                        sc.showtiming();
            */

            ICustomers[] customers = new ICustomers[2];
            customers[0] = new silvercustomers();
            customers[1] = new GoldCustomer();   

            for(int i  = 0; i <customers.Length; i++)
            {
                customers[i].showtiming();
                customers[i].printTicke(); 
            }
           


           Console.ReadLine();
        }
    }
}
