List<string> favoriteColors = new List<string>()
{
    "green", "yellow", "pink",
    "blue", "red", "green",
    "pink", "yellow", "yellow",
    "black", "pink", "brown",
    "orange","orange","purple"
};

void PrintFavoriteColors(List<string> colors)
{
    Dictionary<string, int> colorCounts = new Dictionary<string, int>();
    foreach (string color in colors)
    {
        colorCounts[color] = colorCounts.GetValueOrDefault(color) + 1;
    }
    foreach (var (color, count) in colorCounts)
    {
        SetColor(color);
        if (colorCounts[color] == 1)
        {
            Console.WriteLine($"The color {color} appears 1 time");
        }
        else
        {
            Console.WriteLine($"The color {color} appears {count} times");
        }
    }
}

void SetColor(string color)
{
    if (color == "red")
        Console.ForegroundColor = ConsoleColor.Red;
    else if (color == "blue")
        Console.ForegroundColor = ConsoleColor.Blue;
    else if (color == "black")
        Console.ForegroundColor = ConsoleColor.Black;
    else if (color == "yellow")
        Console.ForegroundColor = ConsoleColor.Yellow;
    else if (color == "orange")
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    else if (color == "purple")
        Console.ForegroundColor = ConsoleColor.Magenta;
    else
        Console.ResetColor();
}

PrintFavoriteColors(favoriteColors);
Console.ResetColor();