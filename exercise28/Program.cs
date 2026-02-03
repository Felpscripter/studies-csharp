List<int> numbers = new List<int>();

numbers.Add(5);

foreach(int n in numbers)
{
    Console.WriteLine(n);
}

List<int> num = new List<int> {1,2,3,4,5,6,7,8,9,10};

num.Remove(5);

foreach(int n2 in num)
{
    Console.WriteLine(n2);
}

List<string> words = new List<string>{"Hello! ", "How are", "you?"};

foreach(string w in words)
{
    Console.WriteLine(w);
}


List<int> numTest = new List<int>{5, 10, 15, 20, 25};

foreach (int nTest in numTest)
{
    Console.WriteLine(nTest);
}

numTest.Remove(15);

foreach (int nTest2 in numTest)
{
    if (nTest2 >= 10)
    {
        Console.WriteLine(nTest2);
    }
}

