using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bools are cool, you can use them to represent true/false values.
            //They can be very useful in conditional statements and logical operations.
            //If one thing is equal to another thing then we can take another path.


            bool value = true;

            bool isMale = true;
            Console.WriteLine(isMale);

            //Reminder that you can use the letters cw on a new line as a shortcut to Console.WriteLine();
            //Just like any variable you can assign them new values later on.

            isMale = false;
            Console.WriteLine(isMale);

            Console.ReadLine();
        }
    }
}
