using NUnit.Framework;
using Mindbox.Square;

namespace TemplateMethod.UnitTests.Square
{
   
    public class CircleSquareTests
    {
        [TestCase]
        public void Square_10_Return_314_2()
        {
            var circle = new CircleSquare(10);
            circle.Calculate();

            var expected = 314.159;
            var actual = circle.Square;
            var delta = 0.001;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestCase]
        public void Square_0_Return_0()
        {
            var circle = new CircleSquare(0);
            circle.Calculate();

            var expected = 0;
            var actual = circle.Square;

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Square_less_than_zero_Return_0()
        {
            var circle = new CircleSquare(-10);
            circle.Calculate();

            var expected = 0;
            var actual = circle.Square;

            Assert.AreEqual(expected, actual);
        }
    }
}
