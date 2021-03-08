using System;
using System.Globalization;

namespace mydate
{
    class Program
    {
        static void Main(string[] args)
        {
            // The date should be printed in this format: "Mon Mar   8 11:54:05 AM CST 2021"
            DateTime current = DateTime.Now;
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            string dayMonthDate = current.ToString("ddd MMM d");
            string time = current.ToString("T");
            string year = current.ToString("yyyy");
            string timeSetting = localZone.IsDaylightSavingTime(current) 
                ? localZone.DaylightName : localZone.StandardName;
            Console.WriteLine(dayMonthDate + " " + time + " " + timeSetting + " " + year);
        }
    }
}
