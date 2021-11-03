using NUnit.Framework;

namespace Homework5.Tests
{
    public class HW5Tests
    {
        private HW5 _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }


        [TestCase(0, 5 )]
        [TestCase(1, -11)]
        [TestCase(2, -13)]
        [TestCase(3, 1)]
        [TestCase(-1, 0)]

        public void GetMinNumberOfArrayTest(int a, int expected)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetMinNumberOfArrayTest(a);
            //act
            int actual = _hw5.GetMinNumberOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(0, 78 )]
        [TestCase(1, 4)]
        [TestCase(2, 0)]
        [TestCase(3, 41)]
        [TestCase(-1, 0)]

        public void GetMaxNumberOfArrayTest(int a, int expected)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetMaxNumberOfArrayTest(a);
            //act
            int actual = _hw5.GetMaxNumberOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(0, new int[] { 1, 0 })]
        [TestCase(1, new int[] { 1, 0 })]
        [TestCase(2, new int[] { 2, 0 })]
        [TestCase(3, new int[] { 0, 1 })]
        [TestCase(-1, new int[] { })]

        public void GetIndexOfMinNumberOfArrayTest(int a, int[] expected)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetIndexOfMinNumberOfArray(a);
            //act
            int[] actual = _hw5.GetIndexOfMinNumberOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(0, new int[] { 1, 0})]
        [TestCase(1, new int[] { 1, 1 })]
        [TestCase(2, new int[] { 1, 2 })]
        [TestCase(3, new int[] { 0,1 })]
        [TestCase(-1, new int[] { })]

        public void GetIndexOfMaxNumberOfArrayTest(int a, int[] expected)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetIndexOfMaxNumberOfArray(a);
            //act
            int[] actual = _hw5.GetIndexOfMaxNumberOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(3, 1)]
        [TestCase(-1, 0)]

        public void GetCountOfElementsThatGreaterThanNeighborsTest(int a, int expected)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetCountOfElementsThatGreaterThanNeighbors(a);
            //act
            int actual = _hw5.GetCountOfElementsThatGreaterThanNeighbors(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void FlipArrayRelativeItsMainDiagonalTest(int a)
        {
            //arrange
            int[,] array = TestData.GetArrayForFlipArrayRelativeItsMainDiagonal(a);
            int[,] expected = TestData.GetExpectedArrayForFlipArrayRelativeItsMainDiagonal(a);
            //act
            _hw5.FlipArrayRelativeItsMainDiagonal(ref array);
            //assert
            Assert.AreEqual(expected, array);
        }
    }
}