using System;

public class Video
{
    private string _title;
    private string _author;
    private double _lengthInSeconds;
    private List<Comment> _comments;

    public Video()
    {
        _title = "Untitled Video";
        _author = "Unknown";
        _lengthInSeconds = 0;
        _comments = new List<Comment>();
    }
    
    public Video(string title, string author)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = 0;
        _comments = new List<Comment>();
    }
    
    public Video(string title, string author, double lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    
    public Video(string title, string author, double lengthInSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = comments;
    }

    public string sec2Min(double seconds)
    {
        int minutes = (int)(seconds / 60);
        int secondsRemaining = (int)(seconds % 60);

        return $"{minutes}:{secondsRemaining:D2}";
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public void Display()
    {
        Console.WriteLine("||-- Video Info --||");
        Console.WriteLine($"{_title} - {_author}\n{sec2Min(_lengthInSeconds)} || {_comments.Count} comments");
        Console.WriteLine();
        Console.WriteLine("||-- Comments Section --||");
        if (_comments == null || _comments.Count == 0)
        {
            Console.WriteLine("No Comments Found! :(");
        }
        else
        {
            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
        }

        Console.WriteLine();
    }
    
}