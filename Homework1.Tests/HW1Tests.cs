using NUnit.Framework;

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

        [Test]
        public void CalcFormulaTest()
        {
            //arrange
            int a = 5;
            int b = 9;
            double expected = 26.5;
            //act
            double actual = _hw1.CalcFormula(5, 9);

            //assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestCase(6, 5, 1)]
        public void GetResultOfDivisionTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw1.GetResultOfDivision(6, 5);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 5, 3)]
        public void GetRemainderOfDivisionTest(int a, int b, double expected)
        {
            //arrange

            //act
            double actual = _hw1.GetRemainderOfDivision(8, 5);
            //assert
            Assert.AreEqual(expected, actual);
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
            double actual = _hw1.CalcEquation(5, 2, 9);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void DeriveEquationOfStraightLineTest()
        {
            //arrange
            int a = 5;
            int b = 2;
            int c = 9;
            int d = 6;
            string expected = "Y = -4X + 2";
            //act
            string actual = _hw1.DeriveEquationOfStraightLine(5,2,9,6);

            //assert
            Assert.AreEqual(expected, actual);
        }
        


    }
}