using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernameChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * This is a simple console application that makes sure a username is not empty.
             * It prompts the user to enter a username and checks if the input is an empty string
            */

            Console.WriteLine("Please enter a username: ");
            string username = Console.ReadLine();

            if (username != string.Empty) // ""
            {
                Console.WriteLine("Username accepted: " + username);
            }
            else
            {
                Console.WriteLine("Error: Username cannot be empty.");
            }

            Console.ReadLine();
        }
    }
}
