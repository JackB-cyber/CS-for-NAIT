using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_Outputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To output values or print text in C#, you can use the WriteLine() method:
            Console.WriteLine();

            // You can add as many WriteLine() methods as you want. Note that it will add a new line for each method:
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            // You can also output numbers, and perform mathematical calculations:
            Console.WriteLine(3 + 3);

            // There is also a Write() method, which is similar to WriteLine().
            // The only difference is that it does not insert a new line at the end of the output:
            Console.Write("Hello World! ");
            Console.Write("I will print on the same line.");
        }
    }
}
