using NUnit.Framework;
using System;

namespace Homework1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;

        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }


        [TestCase(5, 9, 26.5)]
        public void CalcFormulaTest(int a, int b, double expected)
        {
            //arrange
            //act
            double actual = _hw1.CalcFormula(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 5, "Значения a и b должны быть разными")]
        public void CalcFormulaNegativeTest(int a, int b, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.CalcFormula(a, b));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(6, 5, 1)]
        public void GetResultOfDivisionTest(int a, int b, int expected)
        {
            //arrange
            //act
            int actual = _hw1.GetResultOfDivision(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 0, "На ноль делить нельзя!!")]
        public void GetResultOfDivisionNegativeTest(int a, int b, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw1.GetResultOfDivision(a, b));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(8, 5, 3)]
        public void GetRemainderOfDivisionTest(int a, int b, double expected)
        {
            //arrange
            //act
            double actual = _hw1.GetRemainderOfDivision(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(6, 0, "На ноль делить нельзя!!")]
        public void GetRemainderOfDivisionNegativeTest(int a, int b, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw1.GetRemainderOfDivision(a, b));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [Test]
        public void CalcEquationTest()
        {
            //arrange
            int a = 5;
            int b = 2;
            int c = 9;
            double expected = 1.4;
            //act
            double actual = _hw1.CalcEquation(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 6, 8, "На ноль делить нельзя!!")]
        public void CalcEquationNegativeTest(int a, int b, int c, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw1.CalcEquation(a, b, c));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(5, 2, 9, 6, "Y = -4X + 2")]
        [TestCase(7, -4, 9, 1, "Y = -15X - 4")]
        [TestCase(8, 0, 1, 3, "Y = 3X")]
        public void DeriveEquationOfStraightLineTest(int a, int b, int c, int d, string expected)
        {
            //arrange
            //act
            string actual = _hw1.DeriveEquationOfStraightLine(a, b, c, d);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 2, 5, 6, "Значения a и c должны быть разными")]
        public void DeriveEquationOfStraightLineNegativeTest(int a, int b, int c, int d, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.DeriveEquationOfStraightLine(a, b, c, d));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}
