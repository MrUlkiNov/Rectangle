using System;
using Xunit;
using GeometryApp;
using System.Drawing;

namespace GeometryApp.Tests
{
    public class RectangleTests
    {
        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(2.5, 4, 10)]
        [InlineData(3, 3, 9)]
        public void CalculateArea_ReturnsCorrectArea(double width, double height, double expectedArea)
        {
            var rectangle = new Rectangle(width, height);
            var area = rectangle.CalculateArea();
            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(5, 0)]
        [InlineData(-3, 3)]
        public void Rectangle_InvalidDimensions_ThrowsArgumentException(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }
    }
}
