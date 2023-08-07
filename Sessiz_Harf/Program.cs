using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string ifade giriniz: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        bool[] results = new bool[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            results[i] = ConsonantControl(words[i]);
        }

        Console.WriteLine("Sonuç: " + string.Join(" ", results));
    }

    static bool ConsonantControl(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (!IsVowel(word[i]) && !IsVowel(word[i + 1]))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }
}
