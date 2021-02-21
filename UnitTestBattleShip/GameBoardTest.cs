using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class GameBoardTest
    {
       
        [TestMethod]
        public void TestIsInRange()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("b3b4b5");
            Assert.IsTrue(results);
           

        }

        [TestMethod]
        public void TestBoardSetters()
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.Height = 6;

            Assert.AreEqual(gameBoard.Height, 6);

        }



    }
}
