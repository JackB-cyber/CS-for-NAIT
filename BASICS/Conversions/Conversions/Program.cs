using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If you're attempting to run string conversion while your strings has a character inside the "", you will get a Runtime Error.
            //This can be fixed in the future using exception handling using functions like try pass. Dont worry about this too much for now.
            string textAge = "25";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            //Because we use textBigNumber in "" we don't need to include the L at the end.
            //The L is just to indicate to the compiler that we want to use int64 and not int32.
            //Please refer to DataTypes if confused by this explanation.

            string textBigNumber = "9000000000"; 
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-3.14";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);


            //Floats are different, hover over float C#'s definition of a float is single.
            //When using convert on a float you use Convert.ToSingle().
            //Sidenote: if you are ever having trouble with conversions you should double check the definition of the datatype you are trying to convert.

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "19.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
