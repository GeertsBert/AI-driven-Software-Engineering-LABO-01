string choice = "";
do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    choice = Console.ReadLine();

    if(choice == "1")
    {
        int num1 = ReadNumber("Enter your first number: ");
        int num2 = ReadNumber("Enter your second number: ");
        int result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result}");
    }
    if(choice == "2")
    {
        int num1 = ReadNumber("Enter your first number: ");
        int num2 = ReadNumber("Enter your second number: ");
        int result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result}");
    }
    if(choice == "3")
    {
        int num1 = ReadNumber("Enter your first number: ");
        int num2 = ReadNumber("Enter your second number: ");
        int result = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {result}");
    }
    if(choice == "4")
    {
        int num1 = ReadNumber("Enter your first number: ");
        int num2 = ReadNumber("Enter your second number: ");
        double result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result}");
    }

    if(choice == "5")
    {
        Environment.Exit(0);
    }
    Console.WriteLine();
}while (choice!= "5");



int ReadNumber(string title)
{
    Console.Write(title);
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}
