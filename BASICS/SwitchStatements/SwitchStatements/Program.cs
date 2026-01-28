using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use the switch statement to select one of many code blocks to be executed

            // The switch expression is evaluated once
            // The value of the expression is compared with the values of each case
            // If there is a match, the associated block of code is executed

            // Example:
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

            // When C# reaches a break keyword, it breaks out of the switch block.
            // This will stop the execution of more code and case testing inside the block.
            // When a match is found, and the job is done, it's time for a break. There is no need for more testing.

            // The default keyword is optional and specifies some code to run if there is no case match:
            int testDay = 4;
            switch (testDay)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."
        }
    }
}
