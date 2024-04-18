using System;

public class Program
{
    public static void Main()
    {
        int[] arrayElements = { 10, 20, 5, 15, 25, 30, 7, 20, 30 };

        Array array = new Array(arrayElements);

        int valueToCompare = 15;
        System.Console.WriteLine($"Скiлькi значень менше {valueToCompare}: {array.Less(valueToCompare)}");
        System.Console.WriteLine($"Скiлькi значень бiльше {valueToCompare}: {array.Greater(valueToCompare)}");

        System.Console.WriteLine("Парнi:");
        array.ShowEven();
        System.Console.WriteLine("Непарнi:");
        array.ShowOdd();

        System.Console.WriteLine($"Скiлькi унiкальних: {array.CountDistinct()}");
        int valueToFind = 20;
        System.Console.WriteLine($"Скiлькi значень рiвних {valueToFind}: {array.EqualToValue(valueToFind)}");
    }
}
