using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        PromptGenerator generator = new PromptGenerator();
        Journal journal = new Journal();

        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry(generator.GetNextPrompt());
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
            }
        }
    }
}