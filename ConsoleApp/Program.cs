using ConsoleApp;

int[] numbers = { 100,200,300 };
Console.WriteLine("Aplikacja do statystyk uruchomiona.");
StatisticsHelper.LogNumbers(numbers);
if (numbers == null || numbers.Length == 0)
{
    Console.WriteLine("Błąd: Tablica nie zawiera danych!");
    return;
}
double average = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine($"Średnia: {average}");
int max = StatisticsHelper.CalculateMax(numbers);
Console.WriteLine($"Maksimum: {max}");
int min = StatisticsHelper.CalculateMin(numbers);
Console.WriteLine($"Minimum: {min}");