using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class GameBoardTest
    {
       
        [TestMethod]
        public void IsShipInRange_ValidShipString_ReturnTrue()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("a1b2H3");
            Assert.IsTrue(results);
        }
        [TestMethod]
        public void IsShipInRange_ValidShotFired_ReturnTrue()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("b8");
            Assert.IsTrue(results);
        }

        [TestMethod]
        public void IsShipInRange_InvalidShotFiredWidthOutofRange_ReturnFalse()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("i2");
            Assert.IsFalse(results);
        }

        [TestMethod]
        public void IsShipInRange_InvalidShotFiredHeightOutofRange_ReturnFalse()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("b9");
            Assert.IsFalse(results);
        }

        [TestMethod]
        public void IsShipInRange_InvalidShotFiredHeightOfZero_ReturnFalse()
        {
            GameBoard gameBoard = new GameBoard();
            bool results = gameBoard.IsShipInRange("b0");
            Assert.IsFalse(results);
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
