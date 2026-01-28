using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // There is also a foreach loop, which is used exclusively to loop through elements in an array:
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
