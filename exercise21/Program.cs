for (int numbers =  1; numbers <= 20; numbers++)
{
    if (numbers == 13)
    {
        break;
    }
    else
    {
        Console.WriteLine(numbers);
    }
}


for (int numbrs = 1; numbrs <= 20; numbrs++)
{
    if (numbrs % 4 == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(numbrs);
    }
}