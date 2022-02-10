using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operators_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- Start Example ----- \\

            decimal x = 55;
            decimal y = 10;

            Console.WriteLine(x + y); // (Addition) Output ==> 65

            // ----------------- \\

            Console.WriteLine(x - y); // (Subtraction) Output ==> 45

            // ----------------- \\

            Console.WriteLine(x * y); // (Multiplication) Output ==> 550

            // ----------------- \\

            Console.WriteLine(x / y); // (Division) Output ==> 5.5

            // ----------------- \\

            Console.WriteLine(x % y); // (Modulus) Output ==> 5

            // ----- End Example ----- \\
        }
    }
}
