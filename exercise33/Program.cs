Queue<string> queue = new Queue<string>();

queue.Enqueue("John");
queue.Enqueue("Maria");
queue.Enqueue("Morgan");
queue.Enqueue("Juliet");
queue.Enqueue("Lourie");

foreach(string x in queue)
{
    Console.WriteLine(x);
}

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());