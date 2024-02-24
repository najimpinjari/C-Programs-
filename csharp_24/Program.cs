using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace csharp_24
{
     class program
    {

        public static void name(string fname)
        {
            console.writeline(fname + " pinjari");
        }
        static void printname(string name)
        {
            console.writeline($" hello  {name}");
        }

        //method with return statment 
        static string printmyname(string fn , string ln)
        //if your method is retur something then you you have to use return statment in the mmethod
        {
            return fn + ln; 
        }

        static void main(string[] args)
        {

            name("najim");

            printname("rupesh");

            string rup = "rupesh";
            printname(rup);


            //calling method with return statemnt 
            //if your method is retur something then you you have to use return statment in the mmethod
            //and you want to see the result of a calling method then you must create a varibale to store a value of method 
            //and store the value of method 
            string result = printmyname("najim", "pinjari");
            console.writeline(result);

            console.readkey();

        }
    }
}
