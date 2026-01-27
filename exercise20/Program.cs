int[] numbers = {1, 2, 3, 4, 5};

foreach (int number in numbers)
{
    Console.WriteLine(number * 2);
}

int[] numbers2 = {6,7,8,9,10,11,12,13,14,15};

foreach (int num in numbers2)
{
    if (num >= 10)
    {
        Console.WriteLine(num);
    }
}

int[] numbers3 = {1,2,3,4,5,6,7,8,9,10,11,12};

foreach (int num2 in numbers3)
{
    if (num2 % 3 == 0)
    {
        Console.WriteLine(num2);
    }
}