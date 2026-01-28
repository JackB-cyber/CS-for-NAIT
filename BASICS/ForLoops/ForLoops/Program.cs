using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Statement 1 sets a variable before the loop starts (int i = 0).

            // Statement 2 defines the condition for the loop to run(i must be less than 5).
            // If the condition is true, the loop will start over again, if it is false, the loop will end.

            // Statement 3 increases a value(i++) each time the code block in the loop has been executed.

            // Nested loops
            // It is also possible to place a loop inside another loop. This is called a nested loop.
            // The "inner loop" will be executed one time for each iteration of the "outer loop":
            
            // Outer loop
            for (int e = 1; e <= 2; ++e)
            {
                Console.WriteLine("Outer: " + e);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }

            // There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
