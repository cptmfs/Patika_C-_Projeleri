using System;

class DaireCiz
{
    public void DrawCircle(int radius)
    {
        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                if (x * x + y * y <= radius * radius)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dairenin yarıçapını giriniz: ");
        int radius = int.Parse(Console.ReadLine());

        DaireCiz daireCiz = new DaireCiz();
        daireCiz.DrawCircle(radius);
    }
}