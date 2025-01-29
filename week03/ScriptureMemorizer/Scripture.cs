using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public void Display()
    {
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", words.Select(w => w.GetText())));
    }
    
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}