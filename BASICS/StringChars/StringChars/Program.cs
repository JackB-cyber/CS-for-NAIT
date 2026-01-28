using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // '' for char, "" for string
            // char is a single character, string is a sequence of characters
            // string can be empty, char cannot be empty

            string name = "Aba";
            char letter = 'a'; 

            Console.Write("Your name is ");
            Console.Write(name);

            Console.WriteLine();
            Console.WriteLine(letter);
            Console.ReadLine();
        }
    }
}
