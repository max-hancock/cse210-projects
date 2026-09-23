using System;

class Program
{
    static void Main(string[] args) // static = function has no class, 
    // void = function tells compiler no value will be returned
    {
       int x = 20;
       int y = 20;
       
       if (x == 10)
       {
        Console.WriteLine("X is 10");
        Console.WriteLine("Y is fun");
       }

       else if (x == 20)
        {
            Console.WriteLine("We are in an else if.");
        }

       else
        {
            Console.WriteLine("Z is not much fun");
        }
    }
}