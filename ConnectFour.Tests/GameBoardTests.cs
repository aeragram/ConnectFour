using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Tests
{
    [TestClass]
    public class GameBoardTests
    {
        [TestMethod]
        public void TestInsertToken()
        {
            GameBoard gameBoard = new GameBoard();

            gameBoard.InsertToken("A_Yellow");
            gameBoard.InsertToken("A_Red");
            gameBoard.InsertToken("A_Yellow");

            Assert.AreEqual( gameBoard.grid[3, 0], 0);

        }
    }
}
