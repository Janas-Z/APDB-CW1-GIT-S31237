namespace ConsoleApp;

public class StatisticsHelper
{
    public static void LogNumbers(int[] numbers)
    {
        Console.WriteLine("Przetwarzane liczby: " + string.Join(", ", numbers));
    }
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        double sum = 0;
        foreach (var n in numbers) sum += n;
        return sum / numbers.Length;
    }
    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (var n in numbers)
        {
            if (n > max) max = n;
        }
        return max;
    }
}