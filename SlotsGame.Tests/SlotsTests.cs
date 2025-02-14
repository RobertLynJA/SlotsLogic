using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace SlotsGame.Tests;

public class SlotsTests
{
    [Fact] 
    public void Constructor_Valid_CreateSlots() 
    {
        // Arrange
        int reels = 3;
        Symbol[] symbols = { new Symbol("1", 1), new Symbol("2", 2), new Symbol("3", 3) };
        
        // Act
        var slots = new Slots(reels, symbols);

        // Assert
        Assert.Equal(3, slots.Symbols.Count());
    }

    [Fact]
    public void Constructor_EmptySymbols_ThrowsException()
    {
        // Arrange
        int reels = 3;
        Symbol[] symbols = { };

        // Act
        var exception = Assert.Throws<ArgumentException>(
            () => new Slots(reels, symbols)
        );

        // Assert
        Assert.Equal("Symbols cannot be empty", exception.Message);
    }

    [Fact]
    public void Constructor_NegativeReels_ThrowsException()
    {
        // Arrange
        int reels = -1;
        Symbol[] symbols = { new Symbol("1", 1), new Symbol("2", 2), new Symbol("3", 3) };

        // Act
        var exception = Assert.Throws<ArgumentException>(
            () => new Slots(reels, symbols)
        );

        // Assert
        Assert.Equal("Reels must be greater than 0", exception.Message);
    }

    [Fact]
    public void Constructor_ZeroReels_ThrowsException()
    {
        // Arrange
        int reels = 0;
        Symbol[] symbols = { new Symbol("1", 1), new Symbol("2", 2), new Symbol("3", 3) };

        // Act
        var exception = Assert.Throws<ArgumentException>(
            () => new Slots(reels, symbols)
        );

        // Assert
        Assert.Equal("Reels must be greater than 0", exception.Message);
    }
}
