bool playAgain = true;

while (playAgain)
{

Console.WriteLine("Welcome to my random number guessing game!");

Random randNum = new Random();


int rn = randNum.Next(1, 101);

int attempts = 0;
int guess = 0;

while (true)
{


    Console.WriteLine("I'm thinking of a number between 1 and 100");
    Console.WriteLine("Try to guess it!");
    string guessstr = Console.ReadLine();
    guess = int.Parse(guessstr);

    if (guess == rn)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("You win!");
        Console.ResetColor();
        break;
    }

    else
    {
        Console.WriteLine("Wrong!");

        if (Math.Abs(guess - rn) > 10) { Console.WriteLine("Way "); }

        if (guess > rn)
        {
            Console.WriteLine("Too high!");
        }

        else if (guess < rn)
        {
            Console.WriteLine("Too low!");
        }

        attempts++; Console.WriteLine($"Current attempts made: {attempts}");
        }
    }
    Console.Write("Would you like to play again? (yes/no): ");
    string playAgainInput = Console.ReadLine().ToLower();
    playAgain = (playAgainInput == "yes" || playAgainInput == "y");

}

Console.WriteLine("Thank you for playing the Number Guessing Game!");


Console.WriteLine("Goodbye!");