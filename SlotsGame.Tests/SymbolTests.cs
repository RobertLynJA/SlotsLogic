namespace SlotsGame.Tests;

public class SymbolTests
{
    [Fact]
    public void Constructor_Valid_CreatesSymbol()
    {
        var symbol = new Symbol("1", 1);

        Assert.Equal("1", symbol.Name);
        Assert.Equal(1, symbol.Value);
    }

    [Fact]
    public void Constructor_ZeroValue_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(
            () => new Symbol("1", 0)
        );
        
        Assert.Equal("Value must be greater than 0", exception.Message);
    }

    [Fact]
    public void Constructor_NegativeValue_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(
            () => new Symbol("1", -1)
        );

        Assert.Equal("Value must be greater than 0", exception.Message);
    }
}
