using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.RightAngleTriangle;

namespace test.RightAngleTriangle
{
/*
Given three coordinates in a 2 dimensional graph, check if they form a right-angled triangle or not
length_between_two_points = sqrt of ((x1 − x2)square + (y1 − y2)square)
 */
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ShouldReturnFalseIfItIsNotRightAngleTriangle()
        {
            Point pointa = new Point(1, 2);
            Point pointb = new Point(2, 8);
            Point pointc = new Point(8, 3);
            Triangle triangle = new Triangle(pointa, pointb, pointc);

            Boolean isRightAngled = triangle.IsRightAngled();
            Assert.IsFalse(isRightAngled);
        }

        [TestMethod]
        public void ShouldReturnTrueIfItIsARightAngleTriangle()
        {
            Point pointb = new Point(1, 8);
            Point pointa = new Point(1, 2);
            Point pointc = new Point(8, 2);
            Triangle triangle = new Triangle(pointa, pointb, pointc);

            Boolean isRightAngled = triangle.IsRightAngled();
            Assert.IsTrue(isRightAngled);
        }

        [TestMethod]
        public void ShouldReturnTrueIfItIsARightAngleTriangle2()
        {
            Point pointa = new Point(5, 0);
            Point pointb = new Point(0, 0);
            Point pointc = new Point(1.8, 2.4);
            Triangle triangle = new Triangle(pointa, pointb, pointc);

            Boolean isRightAngled = triangle.IsRightAngled();
            Assert.IsTrue(isRightAngled);
        }
    }
}
