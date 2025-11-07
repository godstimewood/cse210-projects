using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);  // This generates a number between 1 and 100

            int guess = -1;
            int guessCount = 0;
            Console.WriteLine("\nI'm thinking of a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessAnswer = Console.ReadLine();
                guess = int.Parse(guessAnswer);
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("\nWould you like to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("\nThanks for playing!");
    }
}