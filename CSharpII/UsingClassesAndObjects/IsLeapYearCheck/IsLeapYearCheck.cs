using System;

class IsLeapYearCheck
{
    //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

    static void Main()
    {
        Console.WriteLine("Please enter an year as a number: ");
        IsLeapCheck();
    }

    private static void IsLeapCheck()
    {
        int year = ReturnIntNumber();
        bool isLeap = DateTime.IsLeapYear(year);
        string leapYear = isLeap ? "leap" : "not leap";
        Console.WriteLine("The year {0} is {1} year.", year, leapYear);
    }

    private static int ReturnIntNumber()
    {
        int intNumber = int.Parse(Console.ReadLine());
        return intNumber;
    }
}