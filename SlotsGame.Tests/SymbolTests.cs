namespace SlotsGame.Tests;

public class SymbolTests
{
    [Fact]
    public void Constructor_Valid_CreatesSymbol()
    {
        // Arrange
        string name = "1";
        int value = 1;

        // Act
        Symbol symbol = new (name, value);

        // Assert
        Assert.Equal("1", symbol.Name);
        Assert.Equal(1, symbol.Value);
    }

    [Fact]
    public void Constructor_ZeroValue_ThrowsException()
    {
        // Arrange
        string name = "1";
        int value = 0;

        // Act
        var exception = Assert.Throws<ArgumentException>(
            () => new Symbol(name, value)
        );
        
        // Assert
        Assert.Equal("Value must be greater than 0", exception.Message);
    }

    [Fact]
    public void Constructor_NegativeValue_ThrowsException()
    {
        // Arrange
        string name = "1";
        int value = -1;

        // Act
        var exception = Assert.Throws<ArgumentException>(
            () => new Symbol(name, value)
        );

        // Assert
        Assert.Equal("Value must be greater than 0", exception.Message);
    }
}
