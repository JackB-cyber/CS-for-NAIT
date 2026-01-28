using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckerSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Re-enter password: ");
            string confirmPassword = Console.ReadLine();

            if (!password.Equals(string.Empty) && !confirmPassword.Equals(string.Empty))
            {
                if (password.Equals(confirmPassword))
                {
                    Console.WriteLine("Passwords match");
                }
                else
                {
                    Console.WriteLine("Passwords do not match");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password");
            }
        }
    }
}
