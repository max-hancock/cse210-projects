class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.Write($"{_date}: ");
        Console.WriteLine($"{_prompt} ");
        Console.WriteLine($"Your response: {_response} ");
        Console.WriteLine("");
    }

    public void CreateJournalEntry(string prompt)
    {
        _date = DateTime.Now.ToString("MMMM d, yyyy h:mm tt");
        _prompt = prompt;

        Console.Write($"{_prompt} ");
        _response = Console.ReadLine();
        Console.WriteLine("");
    }

    public string CreateFileString()
    {
    return $"{_date}|{_prompt}|{_response}";
    }
}