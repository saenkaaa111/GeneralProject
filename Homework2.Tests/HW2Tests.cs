using NUnit.Framework;

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
        public void DisplayNumberInLettersTest(int a, string expected)
        {
            //arrange

            //act
            string actual = _hw2.DisplayNumberInLetters(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}