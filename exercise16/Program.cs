Console.WriteLine("What is your name?");
string name = Console.ReadLine()!;

Console.WriteLine("What was your grade?");
int grade = int.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.WriteLine("Loading...");
Console.WriteLine("");

if (grade >= 7 && grade <= 10)
{
    Console.WriteLine($"{name} Situation: Green! You're approved!");
}
else if (grade >= 5)
{
    Console.WriteLine($"{name} Situation: Blue! Ok!");
}
else if (grade >=0 && grade <= 4)
{
    Console.WriteLine($"{name} Situation: Red! Bad notices...");
}
else
{
    Console.WriteLine("Error! Invalid Grade!");
}