using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int addition = 2 + 2; // 4
            float multiplication = 2 * 3; // 6
            float modulus = 5 % 2; // 1

            Console.WriteLine(addition);
            Console.WriteLine(multiplication);
            Console.WriteLine(modulus);

            int sumOf = 4 * 4 + 4 * 4 + 4 - (4 * 4 / 2); //BIDMAS moment

            Console.WriteLine(sumOf);


            /*
            
            Math.Max(x, y); //- returns the highest number
            Math.Min(x, y); //- returns the lowest number
            Math.Sqrt(x);  //- returns the squart root of a number
            Math.Abs(x);   //- returns the values' distance from 0/"the absolute value"
            Math.Round(x); //- returns the value rounded to the nearest whole number
            Math.Pow(x, y); //- returns the value of x with the exponent of y (power of) */

            //ex1
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + num2); //15

            //ex3

            Console.WriteLine(num1 += 15);


            //Math libarary

            //ex1

            Console.WriteLine(Math.Max(234, 433));
            Console.WriteLine(Math.Min(234, 433));
            Console.WriteLine(Math.Pow(5,2));

            //ex2

            float monkey = 3.5F;
            Console.WriteLine(Math.Round(monkey));

            //ex3

            int x = 10;
            int y = 100;
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));




        }
    }
}
