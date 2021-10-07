using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jordan";
            int age = 123;
            Console.WriteLine("Name is " + firstName + ", age is: " + age);

            var firstName2 = "Vinesh";
            var age2 = 4000;
            Console.WriteLine("Name is " + firstName2 + ", age is " + age2);

            int age3;
            age3 = 10;
            Console.WriteLine("Age is: " + age3);

            int int1 = 10, int2 = 20;
            Console.WriteLine(int1 + int2);
        }
    }
}
