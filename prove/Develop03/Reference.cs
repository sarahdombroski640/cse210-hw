public class Reference
{
    private string verseStart;
    private string verseEnd;
    private string chapter;
    private string book;
    private List<string> allReferences = new List<string>();
    private int index;
    private string scriptureText;
    public Reference()
    {
        book = "";
        chapter = "";
        verseStart = "";
        verseEnd = "";
    }
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
    public void GetRandomReference()
    {
        allReferences.Add("1 Nephi,3,7");
        allReferences.Add("2 Nephi,2,27");
        allReferences.Add("Mosiah,2,17");
        allReferences.Add("Helaman,5,12");
        allReferences.Add("Moroni,10,4,5");
        allReferences.Add("D&C,88,124");
        allReferences.Add("Proverbs,3,5,6");

        Random rnd = new Random();
        int randIndex = rnd.Next(allReferences.Count);
        string rndRef = allReferences[randIndex];
        
        List<String> newRef = rndRef.Split(",").ToList();
        
        index = randIndex;
        book = newRef[0];
        chapter = newRef[1];
        verseStart = newRef[2];
        
        if (newRef.Count == 4)
        {
            verseEnd = newRef[3];
        }
        else
        {
            verseEnd = "";
        }
    }
    public string GetScriptureText()
    {
        if (index == 0)
        {
            scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        }
        else if (index == 1)
        {
            scriptureText = "Wherefore, men are free according to the flesh; and call things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.";
        }
        else if (index == 2)
        {
            scriptureText = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        }
        else if (index == 3)
        {
            scriptureText = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        }
        else if (index == 4)
        {
            scriptureText = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        }
        else if (index == 5)
        {
            scriptureText = "Cease to be idle; cease to be unclean; cease to find fault one with another; cease to sleep longer than is needful; retire to thy bed early, that ye may not be weary; arise early, that your bodies and your minds may be invigorated.";
        }
        else if (index == 6)
        {
            scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        return scriptureText;
    }
}