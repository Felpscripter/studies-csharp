int password = 0;

do
{
    Console.WriteLine("What is the password? ");
    int passwordTry = int.Parse(Console.ReadLine()!);
    password = passwordTry;
}

while (password != 1234);

Console.WriteLine("Acess granted!");