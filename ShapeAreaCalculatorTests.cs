using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;

namespace UnitTestAreas
{
    [TestClass]
    public class ShapeAreaCalculatorTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Assert.AreEqual(314, ShapeAreaCalculator.ShapeAreaCalculator.CircleArea(10), 1);
        }

        [TestMethod]
        public void Triangle()
        {
            Assert.AreEqual(50, ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(10, 14.1421356237, 10), 0.5);
        }

        [TestMethod]
        public void Triangle_inpossible()
        {
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(1, 1, 10));
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(10, 1, 1));
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(1, 10, 1));
        }
        [TestMethod]
        public void Triangle_incorrectside()
        {
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(-1, 10, 5));
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(1, -1, 10));
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(8, 10, -1));
            Assert.ThrowsException<System.ArgumentException>(() => ShapeAreaCalculator.ShapeAreaCalculator.TriangleArea(0, 10, 10));
        }
    }
}
