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
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Circle circle = new Circle();

//        Console.Write("Çizmek istediğiniz dairenin yarıçapını giriniz: ");
//        int radius = int.Parse(Console.ReadLine());

//        circle.DrawCircle(radius);

//        Console.ReadKey();
//    }
//}
//public class Circle
//{
//    public void DrawCircle(int radius)
//    {
//        int centerOfX = 20; // X coordinate of center of circle
//        int centerOfY = 10; // Y coordinate of center of circle
//                            // radius of circle

//        // Draw circle
//        for (int y = centerOfY - radius; y <= centerOfY + radius; y++)
//        {
//            for (int x = centerOfX - radius; x <= centerOfX + radius; x++)
//            {
//                double d = Math.Sqrt(Math.Pow(x - centerOfX, 2) + Math.Pow(y - centerOfY, 2));
//                if (d < radius)
//                {
//                    Console.Write("*");
//                }
//                else
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}