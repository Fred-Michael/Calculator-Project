using CalculatorClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorOperationsTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddOperationTest()
        {
            //arrange
            var operand = "+";
            var result = 14;
            var FigureOnScreen = "5";
            var secondfigure = "11";
            var addTest = new Operations();
            var expected = 19;
            var secondexpected = 30;

            //act
            var actual = addTest.PerformOperation(operand, result, FigureOnScreen);
            var secondactual = addTest.PerformOperation(operand, actual, secondfigure);

            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(secondexpected, secondactual);
        }
        [TestMethod]
        public void SubtractOperationTest()
        {
            //arrange
            var operand = "-";
            var result = 20;
            var FigureOnScreen = "11";
            var subtractTest = new Operations();
            var expected = 9;

            //act
            var actual = subtractTest.PerformOperation(operand, result, FigureOnScreen);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplicationOperationTest()
        {
            //arrange
            var operand = "*";
            var result = 9;
            var FigureOnScreen = "7";
            var mulTest = new Operations();
            var expected = 63;

            //act
            var actual = mulTest.PerformOperation(operand, result, FigureOnScreen);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionOperationTest()
        {
            //arrange
            var operand = "/";
            var result = 1430;
            var FigureOnScreen = "8";
            var addTest = new Operations();
            var expected = 178.75;

            //act
            var actual = addTest.PerformOperation(operand, result, FigureOnScreen);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionByZeroTest()
        {
            //arrange
            var operand = "/";
            var result = 19;
            var FigureOnScreen = "0";
            var addTest = new Operations();

            //Act and Assert
            Assert.ThrowsException<DivideByZeroException>(() => addTest.PerformOperation(operand, result, FigureOnScreen));
        }
    }
}
