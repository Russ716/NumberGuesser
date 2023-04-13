using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess;
            int guessesLeft = 4;

            // Loop until the user guesses correctly or runs out of guesses
            while (guessesLeft > 0)
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
            }

            // If the user runs out of guesses, display the secret number
            Console.WriteLine("Sorry, you ran out of guesses. The secret number was {0}.", secretNumber);
        }
    }
}

