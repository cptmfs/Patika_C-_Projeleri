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

    static string SwapCharactersWithPrevious(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 1; i < charArray.Length; i ++) // 
        {
            char temp = charArray[i];
            charArray[i] = charArray[i - 1];
            charArray[i - 1] = temp;
        }

        return new string(charArray);
    }
}
