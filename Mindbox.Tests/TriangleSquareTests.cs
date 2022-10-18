using NUnit.Framework;
using Mindbox.Square;

namespace TemplateMethod.UnitTests.Square
{

    public class TriangleSquareTests
    {
        [TestCase]
        public void Square_3_4_5_Return_6()
        {
            var triangle = new TriangleSquare(3,4,5);
            triangle.Calculate();

            var expected = 6;
            var actual = triangle.Square;

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void RectangleTest()
        {
            var triangle = new TriangleSquare(2,3,4);

            var expected = false;
            var actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}
