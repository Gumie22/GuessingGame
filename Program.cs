//This is a guessing game that only gives the user three tries to guess the correct word
using System;

namespace GuessGame.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hint: It's a drink that is thick and creamy");
            string word = "milkshake";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != word && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("Correct! You Win!");
            }
        }
    }
}