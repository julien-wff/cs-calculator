using Calculator.commands;

namespace Calculator.Tests.commands;

public class VersionCommandTests
{
    [Fact]
    public void Run_ShouldReturnFalse_WhenTooManyArguments()
    {
        // Arrange
        var command = new VersionCommand();
        var args = new[] { "version", "2", "3", "4" };

        // Act
        var result = command.Run(args);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Run_ShouldReturnVersion()
    {
        // Arrange
        var command = new VersionCommand();
        var args = new[] { "version" };

        // Act
        var result = command.Run(args);

        // Assert
        Assert.True(result);
    }
}