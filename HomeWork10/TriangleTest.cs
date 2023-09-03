using HomeWork10;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace HomeWork10.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void PerimeterOfTriangle_3pointsWithCoordinates_returnsCorrectPerimeter()
        {
            Triangle testTriangle = new Triangle(new Point(1, 0), new Point(-4, 5), new Point(8, -2));

            double expectedPerimeter = 28.243621690595795;
            double actualPerimeter = testTriangle.Perimeter();

            Assert.AreEqual(expectedPerimeter, actualPerimeter);

        }

        [TestMethod]
        public void SquareOfTriangle_3pointsWithCoordinates_returnsCorrectSquare()
        {
            Triangle testTriangle = new Triangle(new Point(1, 0), new Point(-4, 5), new Point(8, -2));

            double expectedSquare = 12.499999999999968;
            double actualSquare = testTriangle.Square();

            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        public void PrintInformationAboutTriangleTest()
        {
            Point testVertex1 = new Point(1, 0);
            Point testVertex2 = new Point(-4, 5);
            Point testVertex3 = new Point(8, -2);

            Triangle testTriangle = new Triangle(testVertex1, testVertex2, testVertex3);

            string expected = "Triangle with vertex: A: (1,0), B: (-4,5), C: (8,-2); " +
                "Perimeter of triangle is 28,24; " +
                "Square of triangle is 12,50";
            string actual = $"Triangle with vertex: A: {testVertex1}, B: {testVertex2}, C: {testVertex3}; " +
                $"Perimeter of triangle is {testTriangle.Perimeter():F2}; " +
                $"Square of triangle is {testTriangle.Square():F2}";

            Assert.AreEqual(expected, actual);
        }

        [TestClass]
        public class PointTest
        {
            [TestMethod]
            public void TostringTest()
            {
                Point testPoint = new Point(1, 0);

                string expected = "(1,0)";
                string actual = testPoint.ToString();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}