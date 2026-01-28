using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The break statement can be used to jump out of a loop or switch statement.
            for (int f = 0; f < 10; f++)
            {
                if (f == 4)
                {
                    break;
                }
                Console.WriteLine(f);
            }

            // The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
            for (int a = 0; a < 10; a++)
            {
                if (a == 4)
                {
                    continue;
                }
                Console.WriteLine(a);
            }

            // Break and continue in while loops:
            // Break:
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }

            // Continue:
            int e = 0;
            while (e < 10)
            {
                if (e == 4)
                {
                    e++;
                    continue;
                }
                Console.WriteLine(e);
                e++;
            }
        }
    }
}
