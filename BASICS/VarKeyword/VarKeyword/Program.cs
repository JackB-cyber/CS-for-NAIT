using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So now we know how to really define a variable by specifying its type followed by its name then giving it a value. 
            // Lets see if we can make it simpler.
            // Note: Using var too frequently can hurt the readability of your code because you need to inspect each idividually to see what the datatype is going to be.

            // normally before we would write int age = 25;
            // but with the var keyword we can write:
            var age = 25;
            Console.WriteLine(age);
            // The compiler is smart enough to know that age is an integer because we assigned it the value of 25 which is an integer.

            // But you cant use var age; 
            // This will give an error because the compiler cannot infer the type of age without an initial value.

            var bigNumber = 90000L; // remember the L at the end makes it a long otherwise the var will become an int32 instead of int64
            Console.WriteLine(bigNumber);

            var negative = 3.14D; // the D at the end makes it a double otherwise the var will become a float
            Console.WriteLine(negative);

            var precision = 3.14159F; // the F at the end makes it a float/single
            Console.WriteLine(precision);

            var money = 19.99M; // the M at the end makes it a decimal
            Console.WriteLine(money);

            // You can also use var with strings and chars

            var greeting = "Hello, World!"; // datatype is string
            Console.WriteLine(greeting);

            var letter = 'A'; // datatype is char
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
