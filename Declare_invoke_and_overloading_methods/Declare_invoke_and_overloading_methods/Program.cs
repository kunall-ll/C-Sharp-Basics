using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_invoke_and_overloading_methods
{
    class Program
    {
        static void Main(string[] args)
        { //Calling our method - methods are blocks of code that only run when it's invoked. Data can be passed which is known as parameters, into a method. Methods are used to perform certain actions, and they are also known as functions.
            MyMethod("kunal", 20);
            MyMethod("Jordan", 110);
            MyMethod("Piers", 0);

            int myValue = MyMethod(100);
            //Stores the result to a variable called myValue
            Console.WriteLine(myValue);
            // Will return 200 to the console.

            int myNum1 = addNumbers(8, 5);
            Console.WriteLine("Int: " + myNum1);
            double myNum2 = addNumbers(4.3, 6.26);
            Console.WriteLine("Double: " + myNum2);

           
        }
        // Method defined here called MyMethod
        static void MyMethod(string fname, int age) //parameters passed to the method
        {
            //Console.WriteLine("Our first method in c#");
            Console.WriteLine("Hello " + fname + ", you are " + age + " years old.");
            //Code to execute
            //static means that the method belongs to the Program class and not an object of the Program class
            //void means that this method does not have a return value
        }
        //Method will return an int
        static int MyMethod(int x)
        {
            return 100 + x;
            // Will return the out come of 100 + the value of x
            //Best practice is to store the result into a variable as it is easier to read and maintain.
        }
        //one method takes an int and the other a double which means we don't need to create two different methods e.g. addNumbersInt and addNumbersDouble
        static int addNumbers(int x, int y)
        {
            return x + y;
        }

        static double addNumbers(double x, double y)
        {
            return x + y;
        }

       

    } 


    

   
   
}
