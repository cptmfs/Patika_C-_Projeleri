class FibonacciCalculator
{
    private Dictionary<int, int> fibonacciCache = new Dictionary<int, int>();

    public int CalculateFibonacci(int n)
    {
        if (fibonacciCache.ContainsKey(n))
        {
            return fibonacciCache[n];
        }

        if (n <= 1)
        {
            return n;
        }

        int result = CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        fibonacciCache[n] = result;
        return result;
    }
}

class AverageCalculator
{
    public double CalculateAverage(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        return (double)total / numbers.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Fibonacci serisi derinliği: ");
        int depth = int.Parse(Console.ReadLine());

        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        List<int> fibonacciNumbers = new List<int>();
        for (int i = 0; i < depth; i++)
        {
            fibonacciNumbers.Add(fibonacciCalculator.CalculateFibonacci(i));
        }

        AverageCalculator averageCalculator = new AverageCalculator();
        double average = averageCalculator.CalculateAverage(fibonacciNumbers);

        Console.WriteLine($"Fibonacci serisinin ilk {depth} teriminin ortalaması: {average}");
    }
}
