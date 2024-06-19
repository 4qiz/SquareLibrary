using SquareLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_RegularTriangle_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(4, 5, 6);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void CalculateArea_RightAngledTriangle_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5); // Это прямоугольный треугольник, где 3^2 + 4^2 = 5^2

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void CalculateArea_InvalidTriangle_ThrowsException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }

        [Fact]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = triangle.IsRightAngled();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRightAngled_RegularTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(4, 5, 6);

            // Act
            var result = triangle.IsRightAngled();

            // Assert
            Assert.False(result);
        }
    }
}
