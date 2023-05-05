public class Reference
{
    private string verseStart;
    private string verseEnd;
    private string chapter;
    private string book;
    public Reference(string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verse;
        verseEnd = "";
    }
    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verseStart;
        verseEnd = _verseEnd;
    }
    public string GetReference()
    {
        if (verseEnd == "")
        {
            return ($"{book} {chapter}: {verseStart}");
        }
        else
        {
            return ($"{book} {chapter}: {verseStart}-{verseEnd}");
        }
    }
}