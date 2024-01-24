using System;

namespace Rough
{
    public class Class1
    {

        public static void Main(String[] args)
        {
            var today = DateTime.Today;

            var currentDay = today.Day;
            var currentMonth = today.Month;
            var currentYear = today.Year;

            //Console.WriteLine(currentDay);


            var dateString = currentYear.ToString() + "-" + currentMonth.ToString("D2") + "-" + currentDay.ToString("D2");
            Console.WriteLine(dateString);
            var dateOfJoining = DateTime.Parse(dateString);

            Console.WriteLine(dateOfJoining);
        }

    }
}
