using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string ifade ve bir sayı giriniz (örn. Algoritma,3): ");
        string input = Console.ReadLine();
        string[] inputParts = input.Split(',');

        if (inputParts.Length != 2)
        {
            Console.WriteLine("Hatalı giriş! Lütfen doğru formatta giriş yapın.");
            return;
        }

        string text = inputParts[0].Trim();
        if (!int.TryParse(inputParts[1].Trim(), out int index) || index < 0 || index >= text.Length)
        {
            Console.WriteLine("Geçersiz indeks! Lütfen geçerli bir indeks girin.");
            return;
        }

        string result = RemoveCharacterAtIndex(text, index);
        Console.WriteLine($"Sonuç: {result}");
    }

    static string RemoveCharacterAtIndex(string text, int index)
    {
        return text.Remove(index, 1);
    }
}
