namespace ConsoleApp;

public class StatisticsHelper
{
    public static void LogNumbers(int[] numbers)
    {
        Console.WriteLine("Przetwarzane liczby: " + string.Join(", ", numbers));
    }
}