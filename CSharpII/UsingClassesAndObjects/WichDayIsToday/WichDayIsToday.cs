using System;
using System.Globalization;

class WichDayIsToday
{
    //Write a program that prints to the console which day of the week is today. Use System.DateTime.

    public enum Day
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    
    static void Main()
    {
        string day = DateTime.Today.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
        int dayOfWeek = (int)(Day) Enum.Parse(typeof(Day), day);
        Console.WriteLine("Today is {0}, day {1}",day, dayOfWeek);
    }
}
