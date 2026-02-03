List<int> number = new List<int>{ 3, 7, 12, 18, 21, 25 };
bool existNumber = number.Contains(18);
Console.WriteLine(existNumber);

int existNumber2 = number.Find(n => n > 10);
Console.WriteLine(existNumber2);

bool existEven = number.Any(n => n % 3 != 0);
Console.WriteLine(existEven);