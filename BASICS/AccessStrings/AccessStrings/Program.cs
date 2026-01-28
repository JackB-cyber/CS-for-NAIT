using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can access the characters in a string by referring to its index number inside square brackets [].
            // This example prints the first character in myString:
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            // This example prints the second character (1) in myString:
            string myString = "Hello";
            Console.WriteLine(myString[1]);  // Outputs "e"

            // You can also find the index position of a specific character in a string, by using the IndexOf() method:
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string.
            // This method is often used together with IndexOf() to get the specific character position:
            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);


        }
    }
}
