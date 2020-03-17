using System;
using Xunit;

namespace Shapes.Tests
{
    public class UnitTestBox
    {
        [Fact]
        public void BoxVolumeTest()
        {
            // Arrange 
            Box figure = new Box(10);

            // Act
            double volume = figure.Volume();

            // Assert
            Assert.Equal(1000.0, volume, 5);
        }

        [Theory]
        [InlineData(5, 3)]
        public void TestShapeBoxAdding(double containerHeight, double boxHeight)
        {
            // Arrange
            var container = new Box(containerHeight);
            var figure = new Box(boxHeight);

            // Act
            bool result = container.Add(figure);

            // Assert
            Assert.True(result);
        }
    }

    public class UnitTestCylinder
    {
        [Fact]
        public void CylinderVolumeTest()
        {
            // Arrange 
            Cylinder figure = new Cylinder(2, 10);

            // Act
            double volume = figure.Volume();

            // Assert
            Assert.Equal(125.6637, volume, 4);
        }

        [Theory]
        [InlineData(20, 10, 7)]
        public void TestShapeCylinderAdding(double containerHeight, double cylinderRadius, double cylinderHeight)
        {
            // Arrange 
            var container = new Box(containerHeight);
            var figure = new Cylinder(cylinderRadius, cylinderHeight);

            // Act
            bool result = container.Add(figure);

            // Assert
            Assert.True(result);
        }
    }

    public class UnitTestPyramid
    {
        [Fact]
        public void PyramidVolumeTest()
        {
            // Arrange 
            Pyramid figure = new Pyramid(20, 3);

            // Act
            double volume = figure.Volume();

            // Assert
            Assert.Equal(20.0, volume, 6);
        }

        [Theory]
        [InlineData(3, 1, 4)]
        public void TestShapePyramidAdding(double containerHeight, double pyramidSquare, double pyramidHeight)
        {
            // Arrange 
            var container = new Box(containerHeight);
            var figure = new Pyramid(pyramidSquare, pyramidHeight);

            // Act
            bool result = container.Add(figure);

            // Assert
            Assert.True(result);
        }
    }

    public class UnitTestBall
    {
        [Fact]
        public void BallVolumeTest()
        {
            // Arrange 
            var ball = new Ball(15.0);

            // Act
            double volume = ball.Volume();

            // Assert
            Assert.Equal(14137.167, volume, 3);
        }

        [Theory]
        [InlineData(20, 10)]
        public void TestShapeBallAdding(double containerHeight, double ballRadius)
        {
            // Arrange 
            var container = new Box(containerHeight);
            var figure = new Ball(ballRadius);

            // Act
            bool result = container.Add(figure);

            // Assert
            Assert.True(result);
        }
    }
}