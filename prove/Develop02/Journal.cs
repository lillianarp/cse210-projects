
// AddEntry(newEntry : Entry) : void <- add to the List<Entry>  ✔
// DisplayAll() : void  ✔
// SaveToFile(file : string)  ✔
// LoadFromFile(file : string)  ✔

using System.IO;

public class Journal 
{
    // Responsibilities
    public List<Entry> _entries = new List<Entry>(); // always initialize a list here 

    // Methods
    public void AddEntry(Entry anEntry)
    {
        _entries.Add(anEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // calls the display method in Entry.cs, for each entry
        }
    }

    public void SaveToFile(string file) // write a text file; WriteLine()
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // prevents doubleups 

        string[] lines = File.ReadAllLines(file); 

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3) // make sure each line has 3 parts - date, entry, ?
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry); // don't forget to add each entry from the file to the list 
                // Console.WriteLine($"Added entry: {entry._date} - {entry._promptText} - {entry._entryText}"); // Debugging output
            }
        }
    }

}