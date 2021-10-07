using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while loop - commented out because it's endless lol

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while loop - also endless

            int j = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (j < 5);

            */

            //for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //foreach loop

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            string[] cars2 = { "Lambo", "Lykan Hypersport", "Renault", "Swagmobile" };
            //for loop
            for (int i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine(cars2[i]);
            }
            //for each loop - makes more sense
            foreach (string i in cars2)
            {
                Console.WriteLine(i);
            }

            //Exercise 1

            
            for(int a = 100; a < 200; a++)
            {
                Console.WriteLine(a);
                
                
            }
            

            //exercise 2
            
            
            for(int b = 100; b <=200; b++)
            {
                if (b%2 ==0) { Console.WriteLine("-"); }
                else { Console.WriteLine("*"); }
                
            }

            //exercise 3
            for (int l = 0; l < 10; l++)
            {
                string[] elementarynumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                foreach (string k in elementarynumbers) { Console.WriteLine(k); }
            }

            for (int e = 1; e <= 10; e++)
            {
                for (int f = 1; f <= 10; f++)
                {
                    Console.WriteLine(f);
                
            
                }

            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (j == i) { Console.Write(i); }
                    else { Console.Write(i + ","); }
                    Console.WriteLine();
                }
            }
        }
    }
}
