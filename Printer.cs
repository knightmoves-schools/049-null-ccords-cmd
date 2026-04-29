using System.Text;

namespace knightmoves;

public class Printer
{
    /// <summary>
    /// Uses null-coalescing operator (??) to return "no message" if the input is null.
    /// </summary>
    public string Print(string message)
    {
        return message ?? "no message";
    }

    /// <summary>
    /// Uses null-conditional operator (?.) to safely call ToString() when StringBuilder is null.
    /// </summary>
    public string Print(StringBuilder message)
    {
        return message?.ToString() ?? "no message";
    }
}
