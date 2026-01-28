using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string.
            // Note that you do not have to worry about spaces, like with concatenation:
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            // Also note that you have to use the dollar sign ($) when using the string interpolation method.
        }
    }
}
