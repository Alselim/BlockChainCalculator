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

            //Act
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

            //Act
            var result = calc.Sum(x, y);

            // Assert
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestMul()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Mul(x, y);

            // Assert
            Assert.AreEqual(50, result);
        }
        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Div(x, y);

            // Assert
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestDeg()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            //Act
            var result = calc.Deg(x, y);

            // Assert
            Assert.AreEqual(100000, result);
        }
    }
}
