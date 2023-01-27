using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMindbox.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_SquareTest_15_15_30_55exp()
        {
            double a = 15, b = 15, c = 30;
            double halfP = (a + b + c) / 2d;
            double expected = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();

            Assert.AreEqual(expected, actual);
        }

    }
}
