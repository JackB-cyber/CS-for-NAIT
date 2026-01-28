using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A string variable contains a collection of characters surrounded by double quotes:
            string greeting = "Hello";
            string greeting2 = "Nice to meet you!";


            // A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings.
            // For example, the length of a string can be found with the Length property:
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            // There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:
            string text = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
        }
    }
}
