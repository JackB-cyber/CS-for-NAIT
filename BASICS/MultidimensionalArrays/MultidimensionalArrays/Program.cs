using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A multidimensional array is basically an array of arrays. Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D).
            // To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets:
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            // Good to know: The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].

            // numbers is now an array with two arrays as its elements. The first array element contains three elements:
            // 1, 4 and 2, while the second array element contains 3, 6 and 8. To visualize it, think of the array as a table with rows and columns:

            // To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array.
            // Or better yet, with the table visualization in mind; one for the row and one for the column (see example below).
            int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers2[0, 2]);  // Outputs 2

            // You can also change the value of an element.
            int[,] numbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers3[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers3[0, 0]); // Outputs 5 instead of 1

            // You can easily loop through the elements of a two-dimensional array with a foreach loop:
            int[,] numbers4 = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers4)
            {
                Console.WriteLine(i);
            }
            // You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.
            // Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
            int[,] numbers5 = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int e = 0; e < numbers5.GetLength(0); e++)
            {
                for (int j = 0; j < numbers5.GetLength(1); j++)
                {
                    Console.WriteLine(numbers5[e, j]);
                }
            }

        }
    }
}
