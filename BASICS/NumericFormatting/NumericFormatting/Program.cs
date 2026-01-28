using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sometimes you just want to see fewer digits on the output.

            double value = 1000D / 12.34D; // Output: 81.0129449838188 ew ugly.

            Console.WriteLine(value);

            // So to do that, you can use standard numeric format strings.
            Console.WriteLine(string.Format("{0:0.00}", value)); // what this is saying is "show me two digits after the decimal point" of the first argument (value).
            // The value in this case is rounded with this approach.

            // but even though it looks like the value is rounded, the actual value is still the same.
            Console.WriteLine(value);

            // now you can see that {0} refers to value and {1} refers to 1000 in this case, you seperate arguments using , .
            Console.WriteLine(string.Format("{0} {1}", value, 1000));

            // Lets work with money now

            double money = 10D / 3D; // Output: 3.33333333333333 ew ugly again.
            Console.WriteLine(money);
            Console.WriteLine(string.Format("$$${0:0.00}", money)); // and now since C# knows we're talking about the first argument you can put a $ in front of it or spaces or anything if you want.
            
            // Now we can do things like this:
            Console.WriteLine(string.Format("You owe me $10 / $3 = ${0:0.00}", money));

            // Now what if that money is negative?
            double money2 = -10D / 3D; // remember from conversions, we're going to convert money2 from a double to a string.
            Console.WriteLine(money2.ToString("C")); // Now C# knows we're talking about currency so it adds the $ automatically depending on your location settings.
            Console.WriteLine(money2.ToString("C0")); // C0 for no decimal places
            Console.WriteLine(money2.ToString("C1")); // C1 for one decimal place
            Console.WriteLine(money2.ToString("C2")); // C2 for two decimal places

            // Now if you want to use a different currency type, you can do that too when we are using System.Globalization
            Console.WriteLine(money2.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // this will show the value in () because it's negative
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en-CN"))); // same as above. The reason for this is because the culture of that currency
                                                                                                 // formats negative values in () instead of using - sign.
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en-AU"))); // but AU using a - sign just like GB

            // This important if you want a program that works globally
            Console.ReadLine();
        }
    }
}
