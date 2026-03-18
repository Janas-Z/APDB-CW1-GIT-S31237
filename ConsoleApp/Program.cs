using ConsoleApp;

int[] numbers = { 1, 5, 3, 9, 2 };
Console.WriteLine("Aplikacja do statystyk uruchomiona.");
StatisticsHelper.LogNumbers(numbers);
if (numbers == null || numbers.Length == 0)
{
    Console.WriteLine("Błąd: Tablica nie zawiera danych!");
    return;
}