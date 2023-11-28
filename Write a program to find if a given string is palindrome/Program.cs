using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_a_program_to_find_if_a_given_string_is_palindrome
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine($"Reversed string: {reversed}");
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
