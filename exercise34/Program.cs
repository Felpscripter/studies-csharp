Stack<int> numbers = new Stack<int>();

numbers.Push(15);
numbers.Push(3);
numbers.Push(6);
numbers.Push(9);
numbers.Push(12);

while (numbers.Count > 0)
{
    if (numbers.Peek() % 2 == 0)
    {
        Console.WriteLine(numbers.Pop());
    }
    else
    {
        break;
    }
}