using NUnit.Framework;

namespace Homework4.Tests
{
    public class Tests
    {
        private HW4 _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }


        [TestCase(new int[] { 2, 9, 3, 6, -4, 6, 8, -2, 5}, -4)]
        [TestCase(new int[] { 0, 8, 4, 79}, 0)]
        [TestCase(new int[] { 1589}, 1589)]
        
        public void GetMinNumberOfArrayTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetMinNumberOfArray(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        
        [TestCase(new int[] { 2, 9, 3, 6, -4, 6, 8, -2, 5}, 9)]
        [TestCase(new int[] { 0, 8, 4, 79}, 79)]
        [TestCase(new int[] { 1589}, 1589)]
        
        public void GetMaxNumberOfArrayTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetMaxNumberOfArray(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 9, 3, 6, -4, 6, 8, -2, 5 }, 4)]
        [TestCase(new int[] { 7, 0, 4, 79 }, 1)]
        [TestCase(new int[] { 1589 }, 0)]

        public void GetIndexOfMinNumberOfArrayTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetIndexOfMinNumberOfArray(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { 2, 9, 3, 6, -4, 6, 8, -2, 5 }, 1)]
        [TestCase(new int[] { 7, 0, 4, 79 }, 3)]
        [TestCase(new int[] { 1589 }, 0)]

        public void GetIndexOfMaxNumberOfArrayTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetIndexOfMaxNumberOfArray(a);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 9, 3, 6, -4, 6, 8, -2, 5 }, 19)]
        [TestCase(new int[] { 7, 0, 4, 79 }, 79)]
        [TestCase(new int[] { 1589 }, 0)]

        public void GetSumNumberOddIndexTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetSumNumberOddIndex(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]

        public void GetReversArrayTest(int[] a, int[] expected)
        {
            //arrange

            //act
            _hw4.GetReversArray(ref a);

            //assert
            Assert.AreEqual(expected, a);
        }
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 2, 2, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 9)]

        public void GetSumOddNumberTest(int[] a, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetSumOddNumber(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        
        [TestCase(new int[] {0 }, new int[] {0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3})]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        
        
        public void SwapArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SwapArray(ref array);

            //assert
            Assert.AreEqual(expected, array);
        }
        
        [TestCase(new int[] {0 }, new int[] {0 })]
        [TestCase(new int[] { -1, 56, -85, 74, 15, 696 }, new int[] { -85, -1, 15, 56, 74, 696})]
        
        
        public void SortSelectTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortSelect(array);

            //assert
            Assert.AreEqual(expected, array);
        }
        
        [TestCase(new int[] {0 }, new int[] {0 })]
        [TestCase(new int[] { -1, 56, -85, 74, 15, 696 }, new int[] { 696, 74, 56, 15, -1, -85})]
        
        
        public void SortInsertTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortInsert(array);

            //assert
            Assert.AreEqual(expected, array);
        }
    }
}