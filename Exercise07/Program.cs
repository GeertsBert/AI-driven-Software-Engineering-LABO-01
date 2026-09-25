Dictionary<string, int> scores = new Dictionary<string, int>
{
    { "Jan", 3 },
    { "Paul", 2 },
    { "Jef", 5 },
    { "Bram", 0 },
    { "Pieter", 4 },
    { "Koen", 0 }
};

void DisplayGrades(Dictionary<string, int> scores)
{
    foreach (var (name, score) in scores)
    {
        string result;
        switch (score)
        {
            case 0:
            result = "Insufficient";
            break;
            case 1:
            result = "Insufficient";
            break;
            case 2:
            result = "Weak";
            break;
            case 3:
            result = "average";
            break;
            case 4:
            result = "average";
            break;
            case 5:
            result = "OK";
            break;
            default:
                result = "unknown";
                break;
        }
        Console.WriteLine($"{name}: {result}");
    }

}

DisplayGrades(scores);