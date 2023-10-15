using System;

namespace Section_7_Working_With_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 09, 29);
            var rightNow = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("DateTime of the specified year, month, and date: "+dateTime);
            Console.WriteLine("Now: "+ rightNow);
            Console.WriteLine("Today: "+ today);
            Console.WriteLine("Hour: "+ rightNow.Hour);
            Console.WriteLine("Minute: "+rightNow.Minute);

            var yesterday = rightNow.AddDays(-1);
            var tomorrow = rightNow.AddDays(1);

            Console.WriteLine("Long date: "+ rightNow.ToLongDateString());
            Console.WriteLine("Short date: "+ rightNow.ToShortDateString());
            Console.WriteLine("Long time: " + rightNow.ToLongTimeString());
            Console.WriteLine("Short time: " + rightNow.ToShortTimeString());
            Console.WriteLine("Date and Time: "+ rightNow);
            Console.WriteLine("Formatted Date and Time: {0}",rightNow.ToString("yyyy-MM-dd HH:mm"));

            // Creating timespan

            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Formatted timespan: "+ timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine("Formatted timespan version 1: " + timeSpan1);

            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("Formatted timespan version 2: " + timeSpan2);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: "+duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add And Subtract TimeSpan
            Console.WriteLine("Add Timespan: "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Timespan: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString()
            Console.WriteLine("TimeSpan to string: "+ timeSpan.ToString());

            // Parse()
            Console.WriteLine(("Parse Timespan: "+ TimeSpan.Parse("01:02:03")));


        }
    }
}
