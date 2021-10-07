using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else example

            int age = 22;
            if (age < 18)
            {
                Console.WriteLine("Please show me ID");
            }
            else
            {
                Console.WriteLine("Thank you!");
            }

            //else if example

            int age2 = 2;
            if (age2 < 10)
            {
                Console.WriteLine("Where are you parents?");
            }
            else if (age2 < 18)
            {
                Console.WriteLine("ID please!");
            }
            else
            {
                Console.WriteLine("Thank you");
            }

            //ternary-operator

            //variable = (condition) ? expressionTrue :  expressionFalse;
            int age3 = 12;
            string result = (age3 < 18) ? "Please show me ID" : "Thank you!";
            Console.WriteLine(result);

            //switch case example

            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            sumormultiply(5,10,true);

            blackjack(1, 22);
        }

        //ex1
        public static void sumormultiply(int num1, int num2, bool flag)
        {
            flag = true;
            num2 = 5;
            num1 = 10;
            if (flag == true) { Console.WriteLine(num2 + num1); }
            else if (flag == false) { Console.WriteLine(num2 * num1); }
            else { Console.WriteLine("Flag must be true or false"); }

        }

        //blackjack

        public static void blackjack(int play1, int play2) {
            if (play1 > 21 & play2 > 21) { Console.WriteLine("0"); }
            else if ((21 - play1) > (21 - play2)) { Console.WriteLine(play1); }
            else if ((21 - play2) > (21 - play1)) { Console.WriteLine(play2); }
            else { Console.WriteLine("Play cards again"); }
            }   
            }
        }
       


    

