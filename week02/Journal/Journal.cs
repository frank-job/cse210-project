using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // We save 4 things now: Date ~ Prompt ~ Text ~ Mood
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}~{entry._mood}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
                
                // Safety check: Does this line have a mood?
                if (parts.Length > 3)
                {
                    newEntry._mood = parts[3];
                }
                else
                {
                    newEntry._mood = "N/A";
                }

                _entries.Add(newEntry);
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}