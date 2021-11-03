using NUnit.Framework;
using System;

namespace Homework2.Tests
{
    public class HW2Tests
    {
        
        private HW2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }


        [TestCase(5, 3, 8)]
        [TestCase(3, 5, -2)]
        [TestCase(3, 3, 9)]
        public void CalcFormulaTest(int a, int b, int expected)
        {
            //arrange
            //act
            double actual = _hw2.CalcFormula(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 3, 1)]
        [TestCase(-2, 3, 2)]
        [TestCase(-3, -3, 3)]
        [TestCase(2, -3, 4)]
        [TestCase(0, 3, 0)]
        public void DetermineQuarterTest(int a, int b, int expected)
        {
            //arrange
            //act
            double actual = _hw2.DetermineQuarter(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 3, 6, "3, 5, 6")]
        [TestCase(0, 5, 2, "0, 2, 5")]
        [TestCase(9, 3, 6, "3, 6, 9")]
        public void SortVariablesTest(int a, int b, int c, string expected)
        {
            //arrange
            //act
            string actual = _hw2.SortVariables(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(15, "Пятнадцать")]
        [TestCase(90, "Девяносто ")]
        [TestCase(99, "Девяносто девять")]
        [TestCase(10, "Десять")]
        [TestCase(20, "Двадцать ")]
        [TestCase(9, "девять")]
        public void DisplayNumberInLettersTest(int a, string expected)
        {
            //arrange
            //act
            string actual = _hw2.DisplayNumberInLetters(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "Число должно быть двухзначное")]
        public void DisplayNumberInLettersNegativeTest(int a, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw2.DisplayNumberInLetters(a));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(16, -8, 1, new double[] { 0.25 })]
        [TestCase(9, -6, 2, new double[] {})]
        [TestCase(2, 5, -7, new double[] { 1, -3.5 })]
        [TestCase(4, 0, 0, new double[1] {0.0})]
        
        public void GetRootsOfEquationTest(int a, int b, int c, double[] expected)
        {
            //arrange
            //act
            double[] actual = _hw2.GetRootsOfEquation(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 6, 8, "На ноль делить нельзя!!")]
        public void GetRootsOfEquationNegativeTest(int a, int b, int c, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw2.GetRootsOfEquation(a, b, c));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}