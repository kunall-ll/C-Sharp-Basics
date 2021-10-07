using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
        }
    }
}
