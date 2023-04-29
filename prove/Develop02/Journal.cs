public class Journal
{

    public List<Entry> _entries = new List<Entry>();

        public void DisplayJournalEntries()
        {
            for(int i=0; i<_entries.Count ;i++)
            {
                _entries[i].DisplayEntry();
            }
        }

        public void LoadFromCSV(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                Entry entry = new Entry();

                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                _entries.Add(entry);
            }
        }

        public void SaveToCSV(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                for(int i=0; i<_entries.Count ;i++)
                {
                    string test = _entries[i].GetEntryAsCSV();
                    outputFile.WriteLine(test);
                }
            }
        }

        public void SaveToHTML(string userName)
        {
            string fileName = "/Users/sarahdombroski/Desktop/BYU-I/VSCode/CSE 210/cse210-hw/prove/Develop02/myFile.html";
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine("<!DOCTYPE html>");
                writer.WriteLine("<html lang='en'>");
                writer.WriteLine("<head>");
                writer.WriteLine("<title>My Journal</title>");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<header>");
                writer.WriteLine("<h1>My Journal</h1>");
                writer.WriteLine($"<div>Author: {userName}</div>");
                writer.WriteLine("<p>");
                for(int i=0; i<_entries.Count ;i++)
                {
                    string test = _entries[i].GetEntryAsHTML();
                    writer.WriteLine(test);
                    writer.WriteLine("<br>");
                }
                writer.WriteLine("</p>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }
        }

}