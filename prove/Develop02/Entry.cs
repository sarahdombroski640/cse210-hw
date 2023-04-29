public class Entry
{
    public string _prompt;
    public string _date;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
    public string GetEntryAsCSV()
    {
        string _csvPrompt = ($"{_date}~|~{_prompt}~|~{_response}");
        return _csvPrompt;
    }
    public string GetEntryAsHTML()
    {
        string _htmlFormat = ($"Date: {_date} - Prompt: {_prompt}<br>{_response}");
        return _htmlFormat;
    }
}