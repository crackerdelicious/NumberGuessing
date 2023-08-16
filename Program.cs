using System;
using System.Buffers.Binary;

namespace NumberGuessing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I've selected a number between 1 and 100");
            Console.WriteLine("Try to guess the number.\n");

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            int attempts = 0;
            while (true)
            {
                Console.WriteLine("Enter your guess: ");

                if (int.TryParse(Console.ReadLine(), out int playerGuess))
                {
                    // increase user attemps.
                    attempts++;
                    if (playerGuess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.\n");
                    }
                    else if (playerGuess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.\n");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {attempts} attempts.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                }
            }
        }
    }
}