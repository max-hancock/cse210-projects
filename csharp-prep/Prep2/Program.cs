using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Please enter course grade out of 100: ");
        float studentgrade = float.Parse(Console.ReadLine());

        if (studentgrade >= 90)
        {
            Console.WriteLine("You got an A!");
            Console.WriteLine("Congratulations, you passed the course.");
        }

        else if (studentgrade <= 89 && studentgrade >= 80)
        {
            Console.WriteLine("You got a B");
            Console.WriteLine("Congratulations, you passed the course.");
        }

        else if (studentgrade <= 79 && studentgrade >= 70)
        {
            Console.WriteLine("You got a C");
            Console.WriteLine("Congratulations, you passed the course.");
        }

        else if (studentgrade <= 69 && studentgrade >= 60)
        {
            Console.WriteLine("You got a D");
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the Course.");
        }

}
}