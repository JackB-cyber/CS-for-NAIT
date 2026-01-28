using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops can execute a block of code as long as a specified condition is reached.
            // Loops are handy because they save time, reduce errors, and they make code more readable.

            // The while loop loops through a block of code as long as a specified condition is True:
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // The do/while loop is a variant of the while loop.
            // This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
            int e = 0;
            do
            {
                Console.WriteLine(e);
                e++;
            }
            while (e < 5);

            // Do not forget to increase the variable used in the condition, otherwise the loop will never end!
        }
    }
}
