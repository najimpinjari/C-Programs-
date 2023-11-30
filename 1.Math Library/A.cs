using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Math_Library
{
    public class A
    {
        public void PrintA()
        {
            Console.WriteLine("PrinA()");
        }
        
    }
     public class b : A
    {
        private void Print()
        {
          //  A a = new A();
          //  a.Print();
             
            Console.WriteLine("Printb()");
        }
    }
    public class C 
    {
        private void Print()
        {   
            A a = new A();
            a.PrintA();

            Console.WriteLine("PrintC()");
        }

    }
}
