using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use the if statement to specify a block of C# code to be executed if a condition is True.
            // In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text:
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            // We can also test variables:
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            // Use the else statement to specify a block of code to be executed if the condition is False.
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            // Use the else if statement to specify a new condition if the first condition is False.
            int time2 = 22;
            if (time2 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            // There is also a short-hand if else, which is known as the ternary operator because it consists of three operands.
            // It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:
            
            // Instead of writing:
            int time3 = 20;
            if (time3 < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // You can write this instead:
            int time4 = 20;
            string result = (time4 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            // Keep in mind, however, that readability counts, and overusing the ternary operator can lead to confusing code.
        }
    }
}
