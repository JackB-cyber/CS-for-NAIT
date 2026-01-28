using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PrintInReverseSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string input = Console.ReadLine();

            // Console.WriteLine(input[0]);
            // Console.WriteLine(input.Length);

            for (int i = 0; i < input.Length; i++) // 0-13
            {
                Console.Write(input[i]);
            }

            Console.Write("-");

            for (int i = input.Length - 1; i >= 0; i--) // 13-0
            {
                Console.Write(input[i]);
            }

            Console.ReadLine();
        }
    }
}
