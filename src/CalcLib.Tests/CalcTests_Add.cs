using Xunit;
using CalcLib;

namespace CalcLib.Tests;

public class CalcTests_Add
{

    private readonly Calculator _calc;

    public CalcTests_Add()
    {
        _calc = new Calculator();
    }

    [Fact]
    public void Add_FixNumber()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Act
        int actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [InlineData(1, 1)]
    [InlineData(1, 2)]
    [InlineData(2, 1)]
    [InlineData(2, 2)]
    [Theory]
    public void Add_PositiveNumbers(int a, int b)
    {
        // Arrange
        var expected = a + b;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [InlineData(-1, -1)]
    [InlineData(-1, -2)]
    [InlineData(-2, -1)]
    [InlineData(-2, -2)]
    [Theory]
    public void Add_NegativeNumbers(int a, int b)
    {
        // Arrange
        var expected = a + b;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    [InlineData(-1, 2)]
    [InlineData(1, -2)]
    [InlineData(-2, 1)]
    [InlineData(2, -1)]
    [InlineData(-2, 2)]
    [InlineData(2, -2)]
    [Theory]
    public void Add_MixSignalNumbers(int a, int b)
    {
        // Arrange
        var expected = a + b;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
}