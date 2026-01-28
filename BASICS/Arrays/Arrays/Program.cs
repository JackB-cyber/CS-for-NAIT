using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
            // To declare an array, define the variable type with square brackets:
            string[] cars;

            // We have now declared a variable that holds an array of strings.
            // To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };

            // To create an array of integers, you could write:
            int[] myNum = { 10, 20, 30, 40 };

            // You access an array element by referring to the index number.
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars3[0]);
            // Outputs Volvo

            // To change the value of a specific element, refer to the index number:
            cars2[0] = "Opel";

            // Example
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
            cars4[0] = "Opel";
            Console.WriteLine(cars4[0]);
            // Now outputs Opel instead of Volvo

            // To find out how many elements an array has, use the Length property:
            string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars5.Length);
            // Outputs 4
        }
    }
}
