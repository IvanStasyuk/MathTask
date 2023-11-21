using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTask;

namespace MathTaskTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class GeometryTestsBarrel
    {
        [TestMethod]
        public void BarrelArea_returned()
        {
            double pi = 3.14;
            double b = 15;
            double c = 7;
            double result = 329.7;

            GeometryBarrel n = new GeometryBarrel();
            double actual = n.BarrelArea(pi, b, c);

            Assert.AreEqual(result, actual);
        }
    }
}
