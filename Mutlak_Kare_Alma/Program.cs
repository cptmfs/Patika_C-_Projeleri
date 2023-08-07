using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sayıları girin (örn. '56 45 68 77'): ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int smallerSum = 0; //67
        int biggerSum = 0; //67

        foreach (string num in numbers)
        {
            int currentNum = int.Parse(num);

            if (currentNum < 67)
            {
                smallerSum += 67 - currentNum;
            }
            else
            {
                biggerSum += Math.Abs(67 - currentNum) * Math.Abs(67 - currentNum);
            }
        }

        Console.WriteLine($"Sonuç: {smallerSum} {biggerSum}");
    }
}
