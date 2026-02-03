Dictionary<string, double> products = new Dictionary<string, double>();

products["Notebook"] = 3500;
products["Mouse"] = 120;
products["Keyboard"] = 250;

Console.WriteLine(products["Mouse"]);

foreach (var prod in products)
{
    Console.WriteLine(prod);
}