using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //split method
            string handle = "Hello World";
            string[] resultArray = handle.Split(' ');

            Console.WriteLine(resultArray[1]);

            //equals method
            Console.WriteLine("Hello World".Equals("Hello World"));

            //contains method
            Console.WriteLine("Hello World".Contains("Hello"));

            //replace method
           Console.WriteLine("Hello World".Replace("World", "C#"));

            //escape characters

            Console.WriteLine("Sentence:\n\t- Here is my \"sentence\" on a new line, indented with a tab.");

            //string concatenation

            string string1 = "Hello ";
            string string2 = "World";

            int myNumber = 20;

            Console.WriteLine(string1 + string2);
            Console.WriteLine("Here is " + "my concatenated string");
            Console.WriteLine("myNumber is equal to: " + myNumber);

            //numeric concatenation

            Console.WriteLine("result: " + (10 + 20)); //prints 30
            Console.WriteLine("result: " + 10 + 20); //prints 1020

            //String Interpolation
            string sampleName = "Alex Davies";
            int age = 25;

            Console.WriteLine($"{sampleName} is {age} years old today!");

            //exercise 1

            string petList = "Fox,Cat,Dog,Rabbit,Duck,Parrot";
            string[] petArray = petList.Split(',');
            Console.WriteLine(petArray[3]);

            //exercise 2

            Console.WriteLine(petList.Contains("Dog"));

            //ex 3

            Console.WriteLine("Welcome to the text adventure game! \n name: [username] \n Menu: \n 1.) Play \n 2.) Options \n 3.) Exit game");

           

            
        }
    }
}
