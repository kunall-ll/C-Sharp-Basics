using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);
            //gets the current date and time
            var someTimeAgo = new DateTime(2021, 5, 1, 8, 30, 52);
            Console.WriteLine(someTimeAgo.DayOfWeek);
            //gets the day of the week

            //can also parse values
            Console.WriteLine("Input a date: ");
            var dateInput = Console.ReadLine();
            var convertedDate = DateTime.Parse(dateInput);
            Console.WriteLine(convertedDate + " was/is a " + convertedDate.DayOfWeek);

            //ex

            var future_date = currentDateAndTime.AddYears(5);
            var convertedDate2 = DateTime.Parse(Convert.ToString(future_date));
            Console.WriteLine(convertedDate2 + " will be a " + convertedDate2.DayOfWeek);
        }
    }
}
