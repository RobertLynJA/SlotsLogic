namespace SlotsGame;

public class Symbol
{
    public string Name { get; }
    public int Value { get; }

    public Symbol(string name, int value)
    {
        if (value < 1) 
        {
            throw new ArgumentException("Value must be greater than 0");
        }

        Name = name;
        Value = value;
    }
}
