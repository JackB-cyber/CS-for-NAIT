using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A verbatim string literal is telling C# what you see in a string is what you get.
             * this is useful when writing a file path for example.
             * If you were to write something like this notice the double \\:
            */

            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course"; // when this prints to the screen you will only see ONE \ not two \\.
            // This happens because C#'s escape character is the backslash \ so it escapes with the first \ and prints the second
            Console.WriteLine(path);

            // So how do we make this easier for us?
            // This is our friend the Verbatim String Literal prefix, @.
            // It lets us do things like this:

            path = @"C:\\Users\\CoffeeNCode\\Desktop\\C# Course";
            Console.WriteLine(path);
            // Notice now we have the double \\ because its ignoring the escape characters.
            // So lets take write a path with single \ instead using the @ prefix.

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course";
            Console.WriteLine(path);
            // Nice no more double backslashes :)
            // Just remember with a verbatim string literal, you CANNOT use any escape character functions inside of it.

            Console.ReadLine();
        }
    }
}
