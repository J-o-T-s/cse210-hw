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

        Console.WriteLine($"Successfully saved data into {filename}");
        Console.WriteLine(); // empty line
    }
    
    public static void LoadFile(string filename, List<string> contentList)
    {
        if (System.IO.File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            contentList.Clear();
            foreach (string line in lines)
            {
                contentList.Add(line);
            }
        }
        else
        {
            Console.WriteLine($"Sorry, {filename} could not be found, or must have been deleted.");
            Console.WriteLine(); // empty line
        }
    }
}