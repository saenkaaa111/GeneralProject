using NUnit.Framework;

namespace Homework3.Tests
{
    public class HW3Tests
    {
        private HW3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }


        [Test]
        public void RaiseNumberToPowerTest()
        {
            //arrange
            int a = 5;
            int b = 3;
            int expected = 125;
            //act
            double actual = _hw3.RaiseNumberToPower(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(300, "300\t600\t900\t")]
        public void GetNumbersThatDivisibleByNumberFromUserTest(int a, string expected)
        {
            //arrange

            //act
            string actual = _hw3.GetNumbersThatDivisibleByNumberFromUser(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCountOfNumbersWithSquareLessThanNumberFromUserTest()
        {
            //arrange
            int a = 50;
            int expected = 7;
            //act
            int actual = _hw3.GetCountOfNumbersWithSquareLessThanNumberFromUser(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGreatestDivisorTest()
        {
            //arrange
            int a = 522;
            int expected = 261;
            //act
            int actual = _hw3.GetGreatestDivisor(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 29, 70)]
        [TestCase(29, 5, 70)]
        public void GetSumNumbersWhichDivisibleBySevenTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetSumNumbersWhichDivisibleBySeven(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, 89)]
        [TestCase(5, 5)]
        public void GetNumberOfFibonacciRangeTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetNumberOfFibonacciRange(a);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(36, 48, 12)]
        [TestCase(1260, 825, 15)]
        public void GetGreatestCommonDivisorUsingEuclidAlgorithmTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw3.GetGreatestCommonDivisorUsingEuclidAlgorithm(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(125, 5)]
        [TestCase(27, 3)]
        public void GetNumberUsingHalfDivisionMethodTest(int a, int expected)
        {
            //arrange
            
            //act
            int actual = _hw3.GetNumberUsingHalfDivisionMethod(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetOddNumbersTest()
        {
            //arrange
            int a = 56438;
            int expected = 2;
            //act
            int actual = _hw3.GetOddNumbers(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetNumberMirroredTest()
        {
            //arrange
            int a = 16894;
            int expected = 49861;
            //act
            int actual = _hw3.GetNumberMirrored(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetNumbersWhereSumOfEvenDigitsIsGreaterThanOddTest()
        {
            //arrange
            int a = 15;
            string expected = "2\t4\t6\t8\t12\t14\t";
            //act
            string actual = _hw3.GetNumbersWhereSumOfEvenDigitsIsGreaterThanOdd(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 54637, "Да")]
        [TestCase(123, 678, "Нет")]
        public void GSearchIdenticalDigitsTest(int a, int b, string expected)
        {
            //arrange
            
            //act
            string actual = _hw3.SearchIdenticalDigits(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}