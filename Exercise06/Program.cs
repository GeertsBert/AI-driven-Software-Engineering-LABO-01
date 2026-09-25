Dictionary<string, List<int>> purchases = new Dictionary<string, List<int>>();

purchases.Add("jan", new List<int>() { 100, 50, 20 });
purchases.Add("piet", new List<int>() { 10, 70, 20, 4, 58, 542 });
purchases.Add("karel", new List<int>() { 9 });
purchases.Add("sandra", new List<int>() { 45, 45, 10 });


Console.Write("What is the value you want to check? ");
string input = Console.ReadLine();
int minValue = int.Parse(input);


Console.WriteLine($"The following individuals had a shopping cart value higher than € {minValue}:");

foreach (var (shopper, cart) in purchases.OrderBy(location => location.Key))
{
    int value = 0;
    foreach (int basket in cart)
    {
        value += basket;
    }
    if(value > minValue)
    Console.WriteLine($"- {shopper}");
}
