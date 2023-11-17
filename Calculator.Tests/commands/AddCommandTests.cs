using Calculator.commands;

namespace Calculator.Tests.commands;

public class AddCommandTests
{
    [Fact]
    public void Run_ShouldAddTwoNumbersCorrectly()
    {
        // Arrange
        var addCommand = new AddCommand();
        var args = new[] { "add", "2", "3" };

        // Act
        var result = addCommand.Run(args);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Run_ShouldReturnFalse_WhenInvalidArguments()
    {
        // Arrange
        var addCommand = new AddCommand();
        var args = new[] { "add", "2", "invalid" };

        // Act
        var result = addCommand.Run(args);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Run_ShouldReturnFalse_WhenNotEnoughArguments()
    {
        // Arrange
        var addCommand = new AddCommand();
        var args = new[] { "add", "2" };

        // Act
        var result = addCommand.Run(args);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Run_ShouldReturnFalse_WhenTooManyArguments()
    {
        // Arrange
        var addCommand = new AddCommand();
        var args = new[] { "add", "2", "3", "4" };

        // Act
        var result = addCommand.Run(args);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Run_ShouldReturnFalse_WhenArgumentsAreNotNumbers()
    {
        // Arrange
        var addCommand = new AddCommand();
        var args = new[] { "add", "2", "invalid" };

        // Act
        var result = addCommand.Run(args);

        // Assert
        Assert.False(result);
    }
}