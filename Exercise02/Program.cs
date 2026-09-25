//Write ipv WriteLine zo komt de input netjes naast de text.
Console.Write("value A: ");
string valueA = Console.ReadLine();

Console.Write("value B: ");
string valueB = Console.ReadLine();

int a = int.TryParse(valueA);
int b = int.TryParse(valueB);
int sum = a + b;

Console.WriteLine($"The sum of {a} and {b} is {sum}");