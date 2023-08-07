using System;

class Calculator
{
    public double Calculate(string shape, double[] sides)
    {
        switch (shape.ToLower())
        {
            case "daire":
                double radius = sides[0];
                return Math.PI * radius * radius;

            case "üçgen":
                double a = sides[0];
                double b = sides[1];
                double c = sides[2];
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            case "kare":
                double side = sides[0];
                return side * side;

            case "dikdörtgen":
                double width = sides[0];
                double height = sides[1];
                return width * height;

            default:
                throw new ArgumentException("Geçersiz şekil seçimi");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hangi şekli hesaplamak istersiniz? (daire, üçgen, kare, dikdörtgen): ");
        string shape = Console.ReadLine();

        Console.Write("Kenar bilgilerini virgülle ayırarak giriniz: ");
        string sidesInput = Console.ReadLine();
        string[] sidesArray = sidesInput.Split(',');
        double[] sides = Array.ConvertAll(sidesArray, double.Parse);

        Console.Write("Hesaplamak istediğiniz boyutu seçin (alan, çevre): ");
        string dimension = Console.ReadLine();

        Calculator calculator = new Calculator();
        double result = 0;

        try
        {
            result = dimension.ToLower() == "alan"
                ? calculator.Calculate(shape, sides)
                : result; 

            Console.WriteLine($"Sonuç: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }
}
