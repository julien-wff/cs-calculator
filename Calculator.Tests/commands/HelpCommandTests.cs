using Calculator.commands;

namespace Calculator.Tests.commands;

public class HelpCommandTests
{
    [Fact]
    public void Run_ShouldReturnFalse_WhenTooManyArguments()
    {
        // Arrange
        var command = new HelpCommand();
        var args = new[] { "help", "2" };

        // Act
        var result = command.Run(args);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Run_ShouldReturnVersion()
    {
        // Arrange
        var command = new HelpCommand();
        var args = new[] { "help" };

        // Act
        var result = command.Run(args);

        // Assert
        Assert.True(result);
    }
}