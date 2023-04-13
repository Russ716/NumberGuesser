using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the secret number!");
        Console.Write("Enter your guess: ");
        string guess = Console.ReadLine();
        Console.WriteLine("Your guess was: " + guess);
    }
}
