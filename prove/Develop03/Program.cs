using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("Moses", 1, 39);
        Scripture scripture = new Scripture(reference, "Behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}