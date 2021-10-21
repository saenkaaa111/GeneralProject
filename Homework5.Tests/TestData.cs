using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    public class TestData
    {
        public static int[,] GetArrayForGetMinNumberOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 31 }, { 5 } },
                1 => new int[,] { { 9, -2 }, { -11, 42 } },
                2 => new int[,] { { 31, 72, -3 }, { 21, -2, 43 }, { -13, -2, 1 } },
                3 => new int[,] { { 1, 72 } },
                _ => new int[,] { { } },

            };
        }
        
        public static int[,] GetArrayForGetMaxNumberOfArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 5 }, { 78 } },
                1 => new int[,] { { 4, -7 }, { -41, 0 } },
                2 => new int[,] { { 0, -5, -6 }, { -21, -2, -43 }, { -13, -2, -1 } },
                3 => new int[,] { { 41, 5 } },
                _ => new int[,] { { } },

            };
        }
        
        public static int[,] GetArrayForGetIndexOfMinNumberOfArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 31 }, { 5 } },
                1 => new int[,] { { 9, -2 }, { -11, 42 } },
                2 => new int[,] { { 31, 72, -3 }, { 21, -2, 43 }, { -13, -2, 1 } },
                3 => new int[,] { { 71, 1 } },
                _ => new int[,] { { } },

            };
        }

        public static int[,] GetArrayForGetIndexOfMaxNumberOfArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 5 }, { 78 } },
                1 => new int[,] { { -9, -7 }, { -41, 10 } },
                2 => new int[,] { { -4, -5, -6 }, { -21, -2, 0 }, { -13, -2, -1 } },
                3 => new int[,] { { 8, 59 } },
                _ => new int[,] { { } },

            };
        }
        
        public static int[,] GetArrayForGetCountOfElementsThatGreaterThanNeighbors(int index)
        {
            return index switch
            {
                0 => new int[,] { { 15 }, { 0 } },
                1 => new int[,] { { 9, 7 }, { 41, 10 } },
                2 => new int[,] { { -4, 5, -6 }, { -21, -2, 0 }, { -13, -2, -1 }, { 3, 98, 1 } },
                3 => new int[,] { { -8, 59 } },
                _ => new int[,] { { } },

            };
        }

        public static int[,] GetArrayForFlipArrayRelativeItsMainDiagonal(int index)
        {
            return index switch
            {
                0 => new int[,] { { 9, 7, 6 }, { 41, 10, 5 }, { 96, 8, 0 } },
                1 => new int[,] { { -8, 59 }, { 7, 1 } },
                _ => new int[,] { { } },

            };
        }
        public static int[,] GetExpectedArrayForFlipArrayRelativeItsMainDiagonal(int index)
        {
            return index switch
            {
                0 => new int[,] { { 9, 41, 96 }, { 7, 10, 8 }, { 6, 5, 0 } },
                1 => new int[,] { { -8, 7 }, { 59, 1 } },
                _ => new int[,] { { } },

            };
        }







    }
}
