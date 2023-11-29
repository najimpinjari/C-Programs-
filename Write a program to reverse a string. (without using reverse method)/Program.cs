using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_a_program_to_reverse_a_string._without_using_reverse_method_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a sentence ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] {' '});

          //  Console.WriteLine("OUTPUT ; \n");
            for(int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]}");
            }






        }
    }


/*  internal class Program
  {
      static void Main(string[] args)
      {

          Console.WriteLine("Please enter your name");
          string name = Console.ReadLine();

          string revercename = string.Empty;

          for(int i = name.Length -1 ; i  >= 0 ; i--)
          {
              revercename += name[i];
          }
          Console.WriteLine($" input {name} ; revercename {revercename}");

      }
  }*/
}
