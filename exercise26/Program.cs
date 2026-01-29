int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};
int numSome = 0;

foreach (int num in numbers)
{
    Console.WriteLine(num);
}

foreach (int num2 in numbers)
{
    if (num2 % 2 == 0)
    {
        Console.WriteLine(num2);
    }
}

foreach (int num3 in numbers)
{
    numSome = numSome + num3;
}

Console.WriteLine(numSome);