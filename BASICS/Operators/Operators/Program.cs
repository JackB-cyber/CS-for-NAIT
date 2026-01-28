using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In this tut we will cover arithmetic operators.
            //We make age equal 25.
            int age = 25;

            //We increment age by 1 using ++.
            //So age is now 26.
            age++;
            Console.WriteLine(age);

            //We decrement age by 1 using --.
            //So age is now 25 again.
            age--;
            Console.WriteLine(age);

            //These are important operators to remember!

            //Another way to increment/decrement is:
            age = age + 1;
            //Increment by 1
            Console.WriteLine(age);
            age = age - 1;
            //Decrement by 1
            Console.WriteLine(age);

            //Written shorthand for the above is:
            age += 1; 
            //Increment by 1
            Console.WriteLine(age);
            age -= 1;
            //Decrement by 1
            Console.WriteLine(age);

            //All of the above methods will give the same result.
            //When you use something like age++/-- though, it will only ever increment/decrement by 1.
            //The other 2 approaches can be used to increment/decrement by any value you want.
            //It is almost always best to just use short hand approaches for code readability.


            // Now we will cover * (multiply) and / (divide) operators.
            int myAge = 25;
            myAge *= 10; // age is now 250
            Console.WriteLine(myAge);

            //Now what about this?
            //What if we went userAge = 27 and divided by 10 it should be 2.7 right?
            int userAge = 27;
            userAge /= 10; // age is now 2 because we are using int data type which only stores whole numbers.
            Console.WriteLine(userAge);

            //If we wanted to store decimal values its best to use a float, double, or decimal data types.

            double preciseAge = 27;
            preciseAge /= 10; // age is now 2.7
            Console.WriteLine(preciseAge);

            //Now we will cover what happens when we use + and - operators with string variables.

            string name = "John";
            name += " Doe"; // now name looks like "John Doe"
            // using -= on a string doesnt really work because it is not built into C#.
            Console.WriteLine(name);

            //Operators and char variables
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);
            //Notice we didnt get ab, thats because it tries to get the unicode values for both of the items.
            //Then adds them together as int values and spits out the unicode value of that int.
            //I wont be covering unicode character maps right now.

            Console.ReadLine();
        }
    }
}
