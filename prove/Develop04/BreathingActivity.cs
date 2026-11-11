class BreathingActivity : BaseActivity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            RunCountDownMessage("Breathe in...", 4);
            RunCountDownMessage("Breathe out...", 6);
        }

        DisplayEndingMessage();
    }
}
