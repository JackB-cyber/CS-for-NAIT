using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserDataExercise
{
    internal class Program
    {
        /* 
         * Define a variable to hold user 
         * Define a var to hold user phone number
         * Define a var to hold user 
         * Print variables line by line to the console
         * Extra: Define variables using var keyword
        */
        
        static void Main(string[] args)
        {
            string name = "Aba";
            int number = 0123456789;
            int age = 25;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            // ahhh but when we run this the phone number loses the leading zero, thats because leading zeros are not stored in int types.
            // so lets fix this by changing the phone number to a string type.

            string phoneNumber = "0123456789";
            Console.WriteLine("This is how you get a leading zero: " + phoneNumber);

            Console.WriteLine();

            // Now that we have defined the variables using explicit types, let's do it again using the var keyword.
            var userName = "Aba";
            var userPhoneNumber = "0123456789";
            var userAge = 25;
            Console.WriteLine(userName);
            Console.WriteLine(userPhoneNumber);
            Console.WriteLine(userAge);

            Console.ReadLine();
        }
    }
}
