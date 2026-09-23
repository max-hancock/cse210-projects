using System;

class Program
{
    static void Main(string[] args) // static = function has no class, 
    // void = function tells compiler no value will be returned
    {
        string firstName;
        string lastName;
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}