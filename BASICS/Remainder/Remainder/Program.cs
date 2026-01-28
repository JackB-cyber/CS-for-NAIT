using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Remainder operator example %

            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum);
            // The value of this in a calculator would be 3.3333 recurring however,
            // because both of these values are integers, the result will also be an integer.

            // So lets see how we can get the remainder of this division instead.
            Console.WriteLine(firstNum % secondNum);
            // The % is called the remainder operator and is a modulus operator.
            // It returns the remainder of a division operation.
            // In this case, 10 divided by 3 is 3 with a remainder of 1.
            // 10 / 3 = 3r1 (3 remainder 1)
            // 3 x 3 = 9, 1 left over (remainder) to get to 10

            // So lets say the secondNum is 2 instead of 3

            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 2 = 0
            // and so on...
            

            Console.WriteLine(1000 % 90); // 10
            Console.WriteLine(100 % 90); // 10
            Console.WriteLine(71 % 10); // 1
            // The closest multiple from 1000 of 90 is 990, so the remainder is 10
            // The closest multiple from 100 of 90 is 90, so the remainder is 10
            // The closest multiple from 71 of 10 is 70, so the remainder is 1

            Console.ReadLine();
        }
    }
}
