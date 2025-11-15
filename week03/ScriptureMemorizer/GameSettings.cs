public class GameSettings
{
    public int HideCount { get; private set; }

    public GameSettings(string difficulty)
    {
        switch (difficulty.ToLower())
        {
            case "easy": HideCount = 1; break;
            case "hard": HideCount = 4; break;
            default: HideCount = 2; break; // normal
        }
    }
}
