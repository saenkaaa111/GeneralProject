using NUnit.Framework;
using System;

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


        [TestCase(5,3,125)]
        [TestCase(5,0,1)]
        [TestCase(5,1,5)]
        [TestCase(5,-2,1)]
        [TestCase(22222222,5, 265938734022126816)]
        [TestCase(5,2222, 8308474023694895977)]
        public void RaiseNumberToPowerTest(int a, int b, long expected)
        {
            //arrange
            //act
            long actual = _hw3.RaiseNumberToPower(a, b);
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

        [TestCase(50,7)]
        public void GetCountOfNumbersWithSquareLessThanNumberFromUserTest(int a, int expected)
        {
            //arrange            
            //act
            int actual = _hw3.GetCountOfNumbersWithSquareLessThanNumberFromUser(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, "Число не должно быть отрицательным")]
        public void GetCountOfNumbersWithSquareLessThanNumberFromUserNegativeTest(int a, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.GetCountOfNumbersWithSquareLessThanNumberFromUser(a));
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(-5, "Число не должно быть меньше нуля")]
        [TestCase(0, "Число не должно быть меньше нуля")]
        public void GetGreatestDivisorNegativeTest(int a, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.GetGreatestDivisor(a));
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(-5, "Число не должно быть меньше нуля")]
        [TestCase(0, "Число не должно быть меньше нуля")]
        public void GetNumberOfFibonacciRangeNegativeTest(int a, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.GetNumberOfFibonacciRange(a));
            Assert.AreEqual(expectedMessage, ex.Message);
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

        [TestCase(-5, 0, "Число не должно быть меньше нуля")]
        public void GetGreatestCommonDivisorUsingEuclidAlgorithmNegativeTest(int a, int b,string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.GetGreatestCommonDivisorUsingEuclidAlgorithm(a,b));
            Assert.AreEqual(expectedMessage, ex.Message);
        }


        [TestCase(125, 5)]
        [TestCase(27, 3)]
        [TestCase(216, 6)]
        [TestCase(512, 8)]
        [TestCase(729, 9)]
        
        public void GetNumberUsingHalfDivisionMethodTest(int a, int expected)
        {
            //arrange            
            //act
            int actual = _hw3.GetNumberUsingHalfDivisionMethod(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(56438,2)]
        [TestCase(-56438,2)]
        [TestCase(0,0)]
        public void GetOddNumbersTest(int a, int expected)
        {
            //arrange
            //act
            int actual = _hw3.GetOddNumbers(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(16894, 49861)]
        [TestCase(16, 61)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(500, 5)]
        [TestCase(5001, 1005)]
        public void GetNumberMirroredTest(int a, int expected)
        {
            //arrange            
            //act
            int actual = _hw3.GetNumberMirrored(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(15, "2\t4\t6\t8\t12\t14\t")]
        [TestCase(24, "2\t4\t6\t8\t12\t14\t16\t18\t20\t21\t22\t24\t")]
        [TestCase(1, "")]
        public void GetNumbersWhereSumOfEvenDigitsIsGreaterThanOddTest(int a, string expected)
        {
            //arrange            
            //act
            string actual = _hw3.GetNumbersWhereSumOfEvenDigitsIsGreaterThanOdd(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, "Число не должно быть меньше нуля")]
        [TestCase(0, "Число не должно быть меньше нуля")]
        public void GetNumbersWhereSumOfEvenDigitsIsGreaterThanOddNegativeTest(int a, string expectedMessage)
        {
            //arrange
            //act
            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.GetNumbersWhereSumOfEvenDigitsIsGreaterThanOdd(a));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(123, 54637, "Да")]
        [TestCase(123, 678, "Нет")]
        [TestCase(0, 103, "Да")]
        [TestCase(103, 0, "Да")]
        [TestCase(0, 0, "Да")]
        public void SearchIdenticalDigitsTest(int a, int b, string expected)
        {
            //arrange
            
            //act
            string actual = _hw3.SearchIdenticalDigits(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}