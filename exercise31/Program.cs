List<int> numbers = new List<int>{ 45, 2, 19, 8, 33, 10 };

numbers.Sort();

foreach (int x in numbers)
{
    Console.WriteLine(x);
}

numbers.Reverse();

foreach (int y in numbers)
{
    Console.WriteLine(y);
}