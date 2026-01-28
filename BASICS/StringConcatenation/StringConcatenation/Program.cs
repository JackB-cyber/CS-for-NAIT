using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The + operator can be used between strings to combine them. This is called concatenation:
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            // Note that we have added a space after "John" to create a space between firstName and lastName on print.

            // You can also use the string.Concat() method to concatenate two strings:
            string fName = "John ";
            string lName = "Doe";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            // C# uses the + operator for both addition and concatenation.
            // Remember: Numbers are added.Strings are concatenated.

            // If you add to ints, the result will be a int:
            int x = 10;
            int y = 20;
            int z = x + y;  // z will be 30 (an integer/number)

            // If you add two strings, the result will be a string concatenation:
            string a = "10";
            string b = "20";
            string c = a + b;  // z will be 1020 (a string)
        }
    }
}
