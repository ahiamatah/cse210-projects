using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Prince Eli's Guessing Game");

        Random compuRanNum = new Random();
        int magicNumber = compuRanNum.Next(1, 101);

        Console.WriteLine("A magic number from 1 - 100.");
        
        int guess;
        string keepPlaying;

        do
        {
            Console.Write("What is your guess: ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess > magicNumber)
            {
                Console.WriteLine("Try again. Guess lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Try again. Guess higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed right.");
            }

            Console.Write("Do you want to keep playing? yes/no:");
            keepPlaying = Console.ReadLine();
        }   while (keepPlaying != "no");

        
        

    }
}