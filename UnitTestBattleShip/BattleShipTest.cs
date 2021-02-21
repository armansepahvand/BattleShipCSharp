using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class BattleShipTest
    {
       
        

        [TestMethod]
        public void TestClassSetters()
        {
            BattleShip battleShip = new BattleShip();
            gameBoard.Height = 6;

            Assert.AreEqual(gameBoard.Height, 6);

        }



    }
}
