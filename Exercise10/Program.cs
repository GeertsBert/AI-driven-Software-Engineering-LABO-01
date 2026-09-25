Dictionary<string, decimal> prices = new Dictionary<string, decimal>
{
    { "trousers", 70.50m },
    { "T-shirt", 20.89m },
    { "vest", 100.30m }
};


Console.WriteLine("Welcome to our clothing store!");

Console.Write("Number of trousers: ");
int trousers = int.Parse(Console.ReadLine());
Console.Write("Number of T-shirts: ");
int shirts = int.Parse(Console.ReadLine());
Console.Write("Number of vests: ");
int vests = int.Parse(Console.ReadLine());

decimal trouserprice = trousers * prices["trousers"];
decimal shirtprice = shirts * prices["T-shirt"];
decimal vestprice = vests * prices["vest"];

decimal totalprice = trouserprice + shirtprice + vestprice;

Console.WriteLine("");
Console.WriteLine($"Total to pay: €{totalprice:F2}");