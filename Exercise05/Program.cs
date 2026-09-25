Dictionary<string, int> locations = new Dictionary<string, int>
{
    { "KWE.P.0.002", 200 },
    { "KWE.P.1.103", 20 },
    { "KWE.A.1.103", 60 },
    { "KWE.A.1.104", 30 },
    { "KWE.A.1.302", 64 },
    { "KWE.A.1.301", 64 }
};

Console.Write("How many students are in your class? ");
string input = Console.ReadLine();
int students = int.Parse(input);


Console.WriteLine($"Suitable classrooms for a group of {students} students are:");

foreach (var (classroom, seats) in locations.OrderBy(location => location.Key))
{
    if (seats >= students * 2)
    {
        Console.WriteLine($"-{classroom}");
    }
}
