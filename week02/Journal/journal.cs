using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(prompt, response, date);
        Entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Load journal from a file
    public void LoadFromFile(string filename)
    {
        Entries.Clear();  // Clear existing entries before loading
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entries.Add(new Entry(prompt, response, date));
            }
        }
    }
}
