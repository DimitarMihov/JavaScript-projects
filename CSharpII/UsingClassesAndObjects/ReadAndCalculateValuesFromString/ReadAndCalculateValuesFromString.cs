using System;

class ReadAndCalculateValuesFromString
{
    /*You are given a sequence of positive integer values written into a string, separated by spaces.
     * Write a function that reads these values from given string and calculates their sum.
     * Example:
		string = "43 68 9 23 318" -> result = 461*/

    static void Main()
    {
        string strValues = "43 68 9 23 318";
        string[] splitValues = strValues.Split(new Char[]{' '});
        int values = 0;
        foreach (var item in splitValues)
        {
            values += int.Parse(item);
        }

        Console.WriteLine(values);
    }
}
