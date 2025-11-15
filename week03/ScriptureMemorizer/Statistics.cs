// Got this program as a compilation from Google, StackOverFlow and ChatGPT
using System.Diagnostics;

public class Statistics
{
    public int Steps { get; private set; }
    public Stopwatch Timer { get; private set; }

    public Statistics()
    {
        Steps = 0;
        Timer = new Stopwatch();
        Timer.Start();
    }

    public void Increment() => Steps++;

    public string GetSummary()
    {
        Timer.Stop();
        return $"Completed in {Steps} steps — Time: {Timer.Elapsed:mm\\:ss}";
    }
}