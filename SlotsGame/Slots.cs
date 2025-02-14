namespace SlotsGame;

public class Slots
{
    public int Reels { get; }
    public IEnumerable<Symbol> Symbols { get; }

    public Slots(int reels, params Symbol[] symbols) 
    {
        if (reels < 1) 
        {
            throw new ArgumentException("Reels must be greater than 0");
        }

        if (symbols.Length < 1)
        {
            throw new ArgumentException("Symbols cannot be empty");
        }

        Reels = reels;
        Symbols = symbols;
    }
}
