class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _unusedPrompts = new List<string>();

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomUnused(_prompts, _unusedPrompts);

        RunCountDownMessage($"List as many responses as you can to the following prompt:\n --- {prompt} --- \n\nYou may begin in", 5);

        Console.Clear();
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine();

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        DisplaySpinnerMessage($"You listed {items.Count} items!", 3);

        DisplayEndingMessage();
    }
}