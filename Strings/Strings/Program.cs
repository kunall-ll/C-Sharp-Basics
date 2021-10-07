using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:"); //strings

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter age:"); //non strings

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("User age is: " + age);

            //exercise 1

            Console.WriteLine("Please enter a number:");
            int entry = Convert.ToInt32(Console.ReadLine());
            while (entry != 0){
                Console.WriteLine("Countdown: " + entry);
                entry--;
                if (entry == 0) { Console.WriteLine("Countdown: Done!"); }
            }
           
            //Exercise 2

            Console.WriteLine("Please enter your name:");
            string userName2 = Console.ReadLine();
            Console.WriteLine(userName2);
            Console.WriteLine("Now, your age:");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age2);
            Console.WriteLine("Lastly, your favourite pet");
            string pet = Console.ReadLine();
            Console.WriteLine("My name is " + userName2 + ", I am " + age2 + " and my favourite pet is " + pet);
        }
    }
    
}
