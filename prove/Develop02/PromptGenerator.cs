
class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What is something new you learned today?",
        "Who is someone you didn't expect to run into today?",
        "What was the best part of your day?",
        "What is one life lesson you learned today?",
        "What was a compliment you received today?"
    };

    private int _index = 0;
    public string GetNextPrompt()
    {
        string prompt = _prompts[_index];
        _index = _index + 1;
        if (_index == _prompts.Count())
        {
            _index = 0;
        }
        return prompt;
    }
}
