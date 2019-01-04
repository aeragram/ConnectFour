using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Tests
{
    [TestClass]
    public class GameBoardTests
    {
        [TestMethod]
        public void InsertToken()
        {
            GameBoard gameBoard = new GameBoard();

            gameBoard.InsertToken("A_Yellow");
            gameBoard.InsertToken("A_Red");
            gameBoard.InsertToken("A_Yellow");

            Assert.AreEqual( gameBoard.grid[3, 0], 0);

        }

        [TestMethod]
        public void InsertTokenIncorrectCollumn()
        {
            GameBoard gameBoard = new GameBoard();

            Assert.IsFalse( gameBoard.InsertToken("H_Red") );
        }

        [TestMethod]
        public void InsertTokenIncorrectPlayer()
        {
            GameBoard gameBoard = new GameBoard();

            Assert.IsFalse( gameBoard.InsertToken("A_Blue") );
        }

        [TestMethod]
        public void InsertTokenCollumnOverload()
        {
            GameBoard gameBoard = new GameBoard();

            gameBoard.InsertToken("A_Yellow");
            gameBoard.InsertToken("A_Red");
            gameBoard.InsertToken("A_Yellow");
            gameBoard.InsertToken("A_Red");
            gameBoard.InsertToken("A_Yellow");
            gameBoard.InsertToken("A_Red");

            Assert.IsFalse( gameBoard.InsertToken("A_Yellow") );
        }


    }
}
