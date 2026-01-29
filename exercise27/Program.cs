int[] numberList = { 2, 5, 8, 11, 14, 17, 20 };
int numbResult = 0;

foreach (int numList in numberList)
{
    if (numList > numbResult)
    {
        numbResult = numList;
    }
}

Console.WriteLine(numbResult);

int[] numberList2 = { 2, 5, 8, 11, 14, 17, 20 };
int numbResult2 = 0;

foreach (int numList2 in numberList2)
{
    if (numList2 % 2 != 0)
    {
        numbResult2 = numbResult2 +1;
    }
}

Console.WriteLine(numbResult2);


int[] numbers = {1,11,15,7,9};
bool found = false;


foreach (int n in numbers)
{
    if (n == 11)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found);