int randomSecretNumber = Math.Abs(new Random().Next() % 100);

Console.WriteLine("Welcome to guess the Number!");
Console.WriteLine("Choose your difficulty level:");
Console.WriteLine("Press A: Easy");
Console.WriteLine("Press B: Medium");
Console.WriteLine("Press C: Difficult");
Console.WriteLine("Press D: Just say that you are boring");

string userDifficulty = Console.ReadLine();
userInputDifficulty(userDifficulty);
int attempts = userInputDifficulty(userDifficulty);

int userInputDifficulty(string userDifficulty)
{
    int numberOfTries = 0;
    if (userDifficulty == "A")
    {
        numberOfTries = 8;
    }
    else if (userDifficulty == "B")
    {
        numberOfTries = 6;
    }
    else if (userDifficulty == "C")
    {
        numberOfTries = 4;
    }
    else if (userDifficulty == "D")
    {
        numberOfTries = int.MaxValue;
    }
    else
    {
        Console.WriteLine("Please enter a valid difficulty level!");
        userInputDifficulty(Console.ReadLine());
    }
    return numberOfTries;
}

Console.WriteLine($"Guess the number between 1 and 100 in {attempts} attempts!");

int userGuess = Convert.ToInt32(Console.ReadLine());
while (userGuess != randomSecretNumber && attempts > 0 && userGuess != 0)
{
    if (userGuess > randomSecretNumber)
    {
        Console.WriteLine("Too high!");
    }
    else if (userGuess < randomSecretNumber)
    {
        Console.WriteLine("Too low!");
    }
    attempts--;
    Console.WriteLine($"You have {attempts} attempts left!");
    userGuess = Convert.ToInt32(Console.ReadLine());
    if (attempts == 0)
    {
        Console.WriteLine("You have run out of attempts!");
    }
    else if (userGuess == randomSecretNumber)
    {
        Console.WriteLine("Congratulations! You guessed the number!");
    }
}