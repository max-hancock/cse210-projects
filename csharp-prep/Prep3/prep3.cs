using System;

class Program
{
    

    static void Main(string[] args)
{
    Console.WriteLine("What is the magic number: ");
    int magicNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("What is your guess: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess > magicNumber)
        Console.WriteLine("Guess lower");

    else if (guess < magicNumber)
        Console.WriteLine("Guess higher");

    else if (guess == magicNumber)
        Console.WriteLine("You guessed the magic number!");

    else
        Console.Write("Not a valid guess, try again");
}
}