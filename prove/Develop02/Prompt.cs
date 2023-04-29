public class Prompt 
{
    public List<string> _prompts = new List<string>();

    public string _GetRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string _random = _prompts[randIndex];
        
        return _random;
    }

    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the best thing I ate today?");
        _prompts.Add("Who did you help today?");
    }
}