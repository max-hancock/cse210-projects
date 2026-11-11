class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private Random _random = new Random();

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a positive whole number: ");
        }
        _duration = seconds;

        DisplaySpinnerMessage("Get ready...", 5);
    }

    public void DisplayEndingMessage()
    {
        DisplaySpinnerMessage("Well done!!", 3);
        DisplaySpinnerMessage($"You have completed another {_duration} seconds of the {_name}.", 5);
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i=seconds; i>= 1; i--)
        {
            Console.Clear();
            Console.Write($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine($"{message}");
        for(int i = 0; i < seconds * 2; i++)
        {
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    protected string GetRandomUnused(List<string> all, List<string> unused)
    {
        if (unused.Count == 0)
        {
            unused.AddRange(all);
        }

        int index = _random.Next(unused.Count);
        string item = unused[index];
        unused.RemoveAt(index);
        return item;
    }
}