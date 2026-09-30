using System;
class Program
{
        static double AddNumbers(double x, int y)
    {
        return x + y;

    }

static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, pleased to meet you.");
    }
    static void Main(string[] args)
    { 
        DisplayGreeting("Bob");
        Console.WriteLine(AddNumbers(12.234, 10));
    }
    // static = function has no class, 
    // {
    // bool done = false;
    // while (! done)
    // {
    //     Console.Write("Are we done (y/n): ");
    //     done = Console.ReadLine().ToLower() == "y";

    // }

    // bool done;
    //     do
    //     {
    //       Console.Write("Are we done (y/n): ");
    //       done = Console.ReadLine().ToLower() == "y";
  
    //     } while(!done);

    // for(int i = 100; i >= 0; i -= 5)
    //     {
    //         Console.WriteLine(i);
    //     }

    // List<string> myFriends = ["Bob", "Betty", "Bobba"];
    //         myFriends.Add("James");
    //         myFriends.Add("John");
    // foreach(string name in myFriends)
    //     {

    //         Console.WriteLine(name);
    //     }


}