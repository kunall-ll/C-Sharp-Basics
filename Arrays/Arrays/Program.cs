using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; //array intilialised with a dataset
            //create an array of integers
            int[] myNum = { 10, 20, 30, 40 };
            //print elements from array
            Console.WriteLine(cars[0]);//Volvo
            Console.WriteLine(cars[1]);//BMW
            Console.WriteLine(cars[2]);//Ford
            Console.WriteLine(cars[3]);//Mazda
            cars[0] = "Audi"; //change element array
            Console.WriteLine(cars[0]);
            //tidier way of iterating through each element
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            int[] myInts = { 5, 1, 8, 9 }; //sorts elements of an array
            Array.Sort(myInts);
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            Array.Sort(cars); //sorts string elements of an array
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 5, 1, 8, 9 }; //more array functions
            Console.WriteLine(myNumbers.Max()); // Will give 9
            Console.WriteLine(myNumbers.Min()); //Will give 1
            Console.WriteLine(myNumbers.Sum()); //Will give 23

            //ex 1&2
            int[] samplearray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in samplearray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(samplearray.Min());//1, I think? Don't quote me
            Console.WriteLine(samplearray.Max());//10
            Console.WriteLine(samplearray.Sum());//55

        }
    }
}
