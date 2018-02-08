using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalc;

namespace ConsoleTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSub()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Sub(x, y);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Sum(x, y);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var result = calc.Div(x, y);
            var result1 = calc.Div(x, 0);

            // Assert
            Assert.AreEqual(2, result);
            Assert.AreEqual(double.PositiveInfinity, result1);
        }

        [TestMethod]
        public void TestPow()
        {
            // Arrange
            var calc = new Calc();
            var x = 2;
            var y = 3;

            // Act
            var result = calc.Pow(x, y);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}
