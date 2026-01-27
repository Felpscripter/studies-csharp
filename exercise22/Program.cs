int intFunction(int a)
{
    return a;
}

int result = intFunction(1);
Console.WriteLine(result);


double doubleFunction(double x, double y)
{
    return x - y;
}

double result2 = doubleFunction(10, 9);
Console.WriteLine(result2);


void welcome()
{
    Console.WriteLine("Hello, Felipe! Welcome to your C# course.");
}

welcome();
welcome();
welcome();
