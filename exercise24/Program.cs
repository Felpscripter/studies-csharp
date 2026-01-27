string helloPeople(string name)
{
    return $"Hello, {name}! How are you? Use Return to do this don't make sense to me.";
}

string mensage = helloPeople("Felipe");
Console.WriteLine(mensage);


int SquareNumberReturn(int number)
{
    int square = number * number;
    return square;
}

int square = SquareNumberReturn(15);
int square2 = SquareNumberReturn(20);
int square3 = SquareNumberReturn(10);
Console.WriteLine(square);
Console.WriteLine(square2);
Console.WriteLine(square3);

Console.WriteLine(SquareNumberReturn(90));