using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt to type your username and press enter
            Console.WriteLine("Enter username: ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            // The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type,
            // such as int. The following program will cause an error:
            // Console.WriteLine("Enter your age:");
            // int age = Console.ReadLine();
            // Console.WriteLine("Your age is: " + age);

            // Luckily, for you, you just learned that you can convert any type explicitly, by using one of the Convert.To methods:
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            // Additionally, if you want to enter info on the same line as the prompt, you can use Console.Write() instead of Console.WriteLine():
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Your city is: " + city);
        }
    }
}
