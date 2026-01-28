using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Now you're familiar with entering a number and converting it to an integer. Let's try it out.
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            Console.WriteLine(num);
            // Works perfectly, but what if the user enters something that isn't a number?
            // Lets TryParse
            Console.Write("Enter a number with a little bit of spice: ");
            string input2 = Console.ReadLine();
            int num2 = 0; // we can actually process variables in TryParse so we dont need to convert it anymore

            int.TryParse(input2, out num2);
            Console.WriteLine(num2);
            // So now lets enter something like "hello" instead of a number and see what happens.
            // Notice that it just returns 0 instead of crashing the program now.

            // Now here is something really important. You should always check the return value of TryParse to see if it was successful.]
            // We can do this with a boolean.
            Console.Write("Enter a number with something nice like 0: "); // enter 0
            string input3 = Console.ReadLine();
            int num3 = 0;
            bool success = int.TryParse(input3, out num3);
            Console.WriteLine(num3);
            // This is how we know if the TryParse worked or not. We need to know if it was successful based on user input or if it just used the default value of 0 on the num variable.
            // We can use an if statement too.

            if (success)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine("That was not a valid number.");
            }

                Console.ReadLine();
        }
    }
}
