using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine("Give me a number, I hate it, let me change that for you >:(");
        string stringNumber = Console.ReadLine();
        int yourNumber = int.Parse(stringNumber);
        int yourDoubleNumber = yourNumber * 7;
        string stringDoubleNumber = yourDoubleNumber.ToString();
        Console.WriteLine("Changed that for ya: " + yourDoubleNumber);
    }
}