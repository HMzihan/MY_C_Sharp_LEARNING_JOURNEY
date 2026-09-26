using System;

class Program
{
    static void Main()
    {
        int value1 = 10;
        int value2 = 3;
        int result;

        result = value1 + value2;
        Console.WriteLine($"{value1} + {value2} = {result}");

        result = value1 - value2;
        Console.WriteLine($"{value1} - {value2} = {result}");

        result = value1 * value2;
        Console.WriteLine($"{value1} * {value2} = {result}");

        double div = (double)value1 / value2;
        Console.WriteLine($"{value1} + {value2} = {div}");

        result = value1 % value2;
        Console.WriteLine($"{value1} % {value2} = {result}");
    }
}