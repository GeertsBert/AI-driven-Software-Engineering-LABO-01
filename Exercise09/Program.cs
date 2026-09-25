Console.Write("Land price: ");
string landInput = Console.ReadLine();
decimal landPrice = decimal.Parse(landInput);

Console.Write("Building price: ");
string buildingInput = Console.ReadLine();
decimal buildingPrice = decimal.Parse(buildingInput);

decimal sum = landPrice + buildingPrice;
decimal totalPrice = sum + (sum *21/100);
Console.WriteLine($"The total price of the project is €{totalPrice}");