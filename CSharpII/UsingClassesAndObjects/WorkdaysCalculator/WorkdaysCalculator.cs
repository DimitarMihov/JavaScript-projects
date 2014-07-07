using System;
using System.Collections.Generic;

class WorkdaysCalculator
{
    /*Write a method that calculates the number of workdays between today and given date, passed as parameter.
     * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified
     * preliminary as array.*/

    
    static void Main()
    {
        Console.Write("Please enter an end date: ");
        DateTime localEnd = DateTime.Parse(Console.ReadLine());
        DateTime localStart = DateTime.Today;
        int allDaysCount = (localEnd - localStart).Days;
        int remainder = allDaysCount % 7;
        for (int i = 0; i < remainder; i++)
        {
            if (DayOfWeek.Saturday.CompareTo(localEnd.AddDays(-i).DayOfWeek) == 0 ||
                DayOfWeek.Sunday.CompareTo(localEnd.AddDays(-i).DayOfWeek) == 0)
            {
                remainder --;
            }
        }

        int allWorkDays = (allDaysCount / 7) * 5 + remainder;
        List<DateTime> hollidays = new List<DateTime>();
        hollidays = FillList();
        int weekend = 0;
        foreach (var holliday in hollidays)
        {
            if (holliday.CompareTo(localEnd) > 0 ||
                holliday.CompareTo(localStart) < 0 ||
                DayOfWeek.Saturday.CompareTo(holliday.DayOfWeek) == 0 || 
                DayOfWeek.Sunday.CompareTo(holliday.DayOfWeek) == 0)
            {
                weekend++;
            }
        }

        int workHollidays = hollidays.Count - weekend;
        allWorkDays -= workHollidays;
        Console.WriteLine("the number of workdays between today and your date is {0}", allWorkDays);
    }

    static List<DateTime> FillList()
    {
        List<DateTime> hollidays = new List<DateTime>();
        Console.WriteLine("Enter an official holliday in format dd.mm.yy! For \"EXIT\" type \"end\"");
        for (int i = 0; i < 1;)
		{
            string dateString = Console.ReadLine();
            if (dateString != "end")
	        {
		        hollidays.Add(DateTime.Parse(dateString));
	        }
            else
	        {
                break;
	        }
		}

        return hollidays;
    }
}