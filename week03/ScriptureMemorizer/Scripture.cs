using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(w => new Word(w))
                     .ToList();
    }

    public void HideRandomWords(int count)
    {
        // Only pick from words not yet hidden
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            Word chosen = visibleWords[_rand.Next(visibleWords.Count)];
            chosen.Hide();
            visibleWords.Remove(chosen);
        }
    }

    public string GetHint()
    {
        var visible = _words.Where(w => !w.IsHidden()).ToList();
        if (visible.Count == 0) return "No hint available.";

        Word random = visible[_rand.Next(visible.Count)];
        return $"Hint: One visible word starts with '{random.GetOriginal()[0]}'";
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden());

    public string GetDisplayText()
    {
        string formatted = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{formatted}";
    }
}
