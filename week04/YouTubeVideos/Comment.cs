using System;

public      class Comment
{
    private string _author;
    private string _context;

    public Comment(string author, string context) // single initializator, comments can't be empty or authorless
    {
        _author = author;
        _context = context;
    }
    
    public void Display()
    {
        Console.WriteLine($"{_author}: {_context}");
    }
}