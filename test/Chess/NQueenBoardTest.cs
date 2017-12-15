using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.Chess;


namespace test.Chess
{
/**
 * In an n x n chess board, when n queens are placed, Should test would there be atleast
 * one pair of queen that will be able to kill out each other.
 * NOTE:
 * 1. Columns are named a-h left to right
 * 2. Rows are numbered 1-8 bottom to top
 * 3. Queen can move horizontally, vertically and diagonally.
 * <p>
 * Example 1:
 * Given 3 x 3 chess board and 3 queens placed in this manner(a2, b1, c3):
 * x x Q
 * Q x x
 * x Q x
 * Result: False
 * <p>
 * Example 2:
 * Given 4 x 4 chess board and 4 queens placed in this manner(a3, b1, c4, d2):
 * x x Q x
 * Q x x x
 * x x x Q
 * x Q x x
 * Result: True
 */
    [TestClass]
    public class NQueenBoardTest
    {
        [TestMethod]
        public void ShouldReturnUnSafeForBoardSize3()
        {
            Assert.IsFalse(new NQueensBoard(3, "b1", "c2", "a3").IsSafe());
        }

        [TestMethod]
        public void ShouldReturnSafeForBoardSize4()
        {
            Assert.IsTrue(new NQueensBoard(4, "b1", "d2", "a3", "c4").IsSafe());
        }

        [TestMethod]
        public void ShouldReturnUnsafeForBoardSize4()
        {
            Assert.IsFalse(new NQueensBoard(4, "a1", "b2", "c3", "d4").IsSafe());
        }

        [TestMethod]
        public void ShouldReturnSafeForBoardSize8()
        {
            Assert.IsTrue(new NQueensBoard(8, "d1", "g2", "c3", "h4", "b5", "e6", "a7", "f8").IsSafe());
        }

        [TestMethod]
        public void ShouldReturnUnsafeForBoardSize8()
        {
            Assert.IsFalse(new NQueensBoard(8, "a1", "b2", "c3", "d4", "e5", "f6", "g7", "h8").IsSafe());
        }

    }
}
