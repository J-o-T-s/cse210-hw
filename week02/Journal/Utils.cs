using System.IO;

public class Utils
{
    public static void SaveFile(string filename, List<string> contents)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in contents)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    
    public static void LoadFile(string filename, List<string> contentList)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        contentList.Clear();
        foreach (string line in lines)
        {
            contentList.Add(line);
        }
    }
}