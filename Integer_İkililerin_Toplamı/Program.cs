using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Integer ikilileri girin (örn. '2 3 1 5'): ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        List<int> results = new List<int>();

        for (int i = 0; i < numbers.Length; i += 2)
        {
            int num1 = int.Parse(numbers[i]);
            int num2 = int.Parse(numbers[i + 1]);

            if (num1 != num2)
            {
                results.Add(num1 + num2);
            }
            else
            {
                results.Add(num1 * num1);
            }
        }

        Console.WriteLine("Sonuç: " + string.Join(" ", results));
    }
}
