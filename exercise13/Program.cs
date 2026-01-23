bool value01 = true;
bool value02 = true;

Console.WriteLine(value01 && value02);

bool value03 = false; 
bool value04 = true;

Console.WriteLine(value03 && value04);

bool value05 = false;
bool value06 = false;

Console.WriteLine(value05 && value06);

Console.WriteLine(value01 || value02);

Console.WriteLine(value03 || value01);

Console.WriteLine(value05 || value06);

bool positive = true;
bool negative = false;

Console.WriteLine(!negative);
Console.WriteLine(!positive);

int age = 18;
bool alcohol = true;

bool CanDrinkAlcohol = age >= 18 && alcohol;
Console.WriteLine(CanDrinkAlcohol);

int ageTwo = 15;
bool drive = false;

bool CanDrive = ageTwo <= 15 && drive;
Console.WriteLine(CanDrive);

Console.WriteLine("Bool! :)");
