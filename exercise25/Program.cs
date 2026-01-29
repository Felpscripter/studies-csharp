void number(int myNumber)
{
    if (myNumber % 2 == 0)
    {
        int myNumberEven = 2;
        Console.WriteLine("Even");
        Console.WriteLine(myNumberEven);
    }
    else
    {
        Console.WriteLine("odd!");
    }
}

Console.WriteLine(myNumberEven);
number(1);
number(2);
number(3);
number(4);
number(5);
number(6);