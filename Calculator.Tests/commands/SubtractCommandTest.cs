using Calculator.commands;

namespace Calculator.Tests.commands
{
    public class SubtractCommandTests
    {
        [Fact]
        public void Run_ShouldSubtractTwoNumbersCorrectly()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "5", "3" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Run_ShouldReturnFalse_WhenInvalidArguments()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "5", "invalid" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Run_ShouldReturnFalse_WhenNotEnoughArguments()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "5" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Run_ShouldReturnFalse_WhenTooManyArguments()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "5", "3", "2" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Run_ShouldReturnFalse_WhenArgumentsAreNotNumbers()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args1 = new[] { "subtract", "invalid", "5" };
            var args2 = new[] { "subtract", "5", "invalid" };

            // Act
            var result1 = subtractCommand.Run(args1);
            var result2 = subtractCommand.Run(args2);

            // Assert
            Assert.False(result1);
            Assert.False(result2);
        }

        [Fact]
        public void Run_ShouldReturnTrue_SupportsNegativeNumbers()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "-5", "-3" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Run_ShouldReturnTrue_SupportsDecimals()
        {
            // Arrange
            var subtractCommand = new SubtractCommand();
            var args = new[] { "subtract", "5.5", "3.5" };

            // Act
            var result = subtractCommand.Run(args);

            // Assert
            Assert.True(result);
        }
    }
}