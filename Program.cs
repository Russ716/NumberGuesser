using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the secret number!");
        for (int i = 0; 1 < 4; i++)
        {

            Console.Write("Enter your guess: ");
            string guess = Console.ReadLine();
            int parsedGuess = int.Parse(guess);
            // Console.WriteLine("Your guess was: " + guess);
            int num = 42;
            if (num == parsedGuess)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                Console.WriteLine("Guess again.");
            }

        }
    }
}
