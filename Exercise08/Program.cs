Console.Write("Max number: ");
string input = Console.ReadLine();
int number = int.Parse(input);

Random random = new Random();
int randomNumber = random.Next(1, number + 1);

int guesses = 0;
int guessNumber=-1;
while (guessNumber != randomNumber)
{
    Console.Write("Guess the number: ");
    string guessInput = Console.ReadLine();
    guessNumber = int.Parse(guessInput);
    guesses += 1;
}
Console.WriteLine($"Congratulations you got it in {guesses} tries");