Console.Write("What is the passport? ");
int passport = int.Parse(Console.ReadLine()!);

while (passport != 0)
{   
    Console.WriteLine("Invalid passport");
    Console.WriteLine($"The code typed is: {passport}");
    Console.Write("What is the passport? ");
    int newCode = int.Parse(Console.ReadLine()!);
    passport = newCode;
}