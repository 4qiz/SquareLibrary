using SquareLibrary.Shapes;

namespace SquareLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 3;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * radius * radius, result);
        }

        [Fact]
        public void CalculateArea_WithZeroRadius_ReturnsZero()
        {
            // Arrange
            double radius = 0;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.CalculateArea();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateArea_WithNegativeRadius_ThrowsException()
        {
            // Arrange
            double radius = -2;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}