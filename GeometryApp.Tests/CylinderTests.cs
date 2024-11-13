using System;
using Xunit;
using GeometryApp;

namespace GeometryApp.Tests
{
    public class CylinderTests
    {
        [Theory]
        [InlineData(3, 5, 141.3716694115407)]
        [InlineData(2, 7, 87.9645943005142)]
        [InlineData(1.5, 4, 28.2743338823081)]
        public void CalculateVolume_ReturnsCorrectVolume(double radius, double height, double expectedVolume)
        {
            var cylinder = new Cylinder(radius, height);
            var volume = cylinder.CalculateVolume();
            Assert.Equal(expectedVolume, volume, 5); // Точность до 5 знаков
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(5, 0)]
        [InlineData(-3, 3)]
        public void Cylinder_InvalidDimensions_ThrowsArgumentException(double radius, double height)
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(radius, height));
        }
    }
}
