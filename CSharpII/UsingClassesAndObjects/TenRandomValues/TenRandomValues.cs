using System;

class TenRandomValues
{
    //Write a program that generates and prints to the console 10 random values in the range [100, 200].

    static void Main()
    {
        Random randGen = new Random();
        Console.WriteLine("Here are ten random values, between 100 and 200 (including):");
        for (int i = 0; i < 10; i++)
        {
            int rand = randGen.Next(100,201);
            Console.Write("{0}, ", rand);

        }
        Console.WriteLine();
    }
}