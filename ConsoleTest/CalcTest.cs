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
    }
}
