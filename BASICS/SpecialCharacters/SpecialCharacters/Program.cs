using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Because strings must be written within quotes, C# will misunderstand this string, and generate an error:

            // string txt = "We are the so-called "Vikings" from the north."; // this would generate an error

            // The solution to avoid this problem, is to use the backslash escape character.
            // The backslash(\) escape character turns special characters into string characters:
            // Escape Character	    Result      Description
            // \'	                '	        Single quote
            // \"	                "	        Double quote
            // \\	                \	        Backslash

            // The sequence \"  inserts a double quote in a string:
            string txt = "We are the so-called \"Vikings\" from the north.";

            // The sequence \'  inserts a single quote in a string:
            string txt2 = "It\'s alright.";

            // The sequence \\  inserts a single backslash in a string:
            string txt3 = "The character \\ is called backslash.";

            // Other useful escape characters are:
            // Escape Character	    Result
            // \n	                New Line
            // \r	                Carriage Return
            // \t	                Tab
            // \b	                Backspace
        }
    }
}
