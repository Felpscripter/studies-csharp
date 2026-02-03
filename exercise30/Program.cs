List<int> numbers = new List<int> { 4, 9, 12, 15, 22, 27, 30 };

numbers.RemoveAll(n => n % 3 == 0);

foreach (int n in numbers)
{
    Console.WriteLine(n);
}