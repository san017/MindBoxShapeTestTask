using MindBoxShapeLib;

namespace MindBoxUnitTest
{
    public class FigureTest
    {
        [Theory]
        [InlineData(4, 50.26548245743669)]
        public void CalculateCorrectSquareTriangle(double radius, double expected)
        {
            var circle = new Circle(radius);

            var result = circle.CalculateSquare();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(0)]
        public void NotCorrectRadiusCircle(double radius)
        {
            Assert.Throws<ArgumentException>(() => { new Circle(radius); });
        }


        [Theory]
        [InlineData(4, 5, 2, 3.799671038392666)]
        public void CalulateCorrectSquareTriangle(double firstSide, double secondSide, double thirdSide, double expected)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var result = triangle.CalculateSquare();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 0, 2)]
        [InlineData(-4, 3, 2)]
        [InlineData(9, 4, 4)]
        public void NotCorrectSideTriangle(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(firstSide, secondSide, thirdSide); });
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void CheckIsRectangular(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.True(triangle.IsRectangular());

        }
    }
}