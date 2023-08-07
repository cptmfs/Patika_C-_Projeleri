using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İfade giriniz:");
        string ifade = Console.ReadLine();
        string result = "";

        for (int i = ifade.Length - 1; i >= 0; i--)
        {
            result += ifade[i];
        }
        Console.WriteLine("Sonuç: " + result);
        Console.ReadKey();
    }

}