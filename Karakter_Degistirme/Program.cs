using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen metninizi giriniz : ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        string[] newWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char firstChar = words[i][0];
            char lastChar = words[i][words[i].Length - 1];

            string newWord = lastChar + words[i].Substring(1, words[i].Length - 2) + firstChar;
            newWords[i] = newWord;

        }

        string output = string.Join(" ", newWords);
        Console.WriteLine($"Sonuç : {output}");
        Console.ReadKey();  
    }

}
