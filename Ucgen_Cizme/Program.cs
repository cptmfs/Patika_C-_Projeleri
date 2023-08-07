using System;

class UcgenCiz
{
    public void DrawTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üçgenin boyutunu giriniz: ");
        int size = int.Parse(Console.ReadLine());

        UcgenCiz ucgenCiz = new UcgenCiz();
        ucgenCiz.DrawTriangle(size);
    }
}
