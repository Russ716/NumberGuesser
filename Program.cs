using System;

class Program
{
    static void Main(string[] args)
    {
        int secretNumber = 42;
        int maxGuesses = 4;
        for (int i = 1; i <= maxGuesses; i++)
        {
            Console.WriteLine("Guess the secret number! You have " + (maxGuesses - i + 1) + " guesses remaining.");
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());
            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations, you guessed the secret number!");
                return;
            }
            else if (i == maxGuesses)
            {
                Console.WriteLine("Sorry, you are out of guesses. The secret number was: " + secretNumber);
            }
            else
            {
                Console.WriteLine("Sorry, your guess is incorrect. Please try again.");
            }
        }
    }
}
