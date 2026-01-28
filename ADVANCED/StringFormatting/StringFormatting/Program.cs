using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Alice";
            int age = 30;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age); // Using concatenation with newline character

            Console.WriteLine("Your name is " + name + ", and you're " + age + " years old"); // This gets a bit long and not super intuitive to read right?

            // Now just like shown in previous lessons. You can actually use curly braces as placeholders then provide the values by using a comma after the string.
            Console.WriteLine("Your name is {0}, and you're {1} years old", name, age);
            // Much cleaner, shorter, and easier to read!

            // So we can make something like a short name/age display pretty easily.
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            Console.ReadLine();
        }
    }
}
