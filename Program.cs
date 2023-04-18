using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the difficulty level
            Console.WriteLine("Select a difficulty level: Easy, Medium, Hard, or Cheater");
            string difficulty = Console.ReadLine();

            // Set the number of guesses based on the difficulty level
            int guesses;
            if (difficulty.ToLower() == "easy")
            {
                guesses = 8;
            }
            else if (difficulty.ToLower() == "medium")
            {
                guesses = 6;
            }
            else if (difficulty.ToLower() == "hard")
            {
                guesses = 4;
            }
            else if (difficulty.ToLower() == "cheater")
            {
                guesses = int.MaxValue; // Set the number of guesses to a very large number so that the loop will continue until the user guesses correctly
            }
            else
            {
                Console.WriteLine("Invalid difficulty level. Exiting...");
                return;
            }

            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess;
            int guessesLeft = guesses;

            // Loop until the user guesses correctly or runs out of guesses
            do
            {
                Console.WriteLine("Guess the secret number (between 1 and 100). You have {0} guesses left.", guessesLeft);

                // Read the user's guess as input
                guess = int.Parse(Console.ReadLine());

                // Check if the guess is correct
                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the secret number!");
                    return;
                }
                else
                {
                    // Tell the user if their guess was too high or too low
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Your guess was too high.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was too low.");
                    }

                    guessesLeft--;
                }
            } while (guessesLeft > 0);

            // If the user runs out of guesses, display the secret number
            Console.WriteLine("Sorry, you ran out of guesses. The secret number was {0}.", secretNumber);
        }
    }
}
