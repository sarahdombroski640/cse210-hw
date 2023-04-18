using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int userGuess = 0;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
        }
        
        Console.WriteLine("You guessed it!");
    }
}