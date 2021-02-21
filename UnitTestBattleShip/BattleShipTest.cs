using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class BattleShipTest
    {
       
        

        [TestMethod]
        public void TestShipSetters()
        {
            Ship battleShip = new Ship("a1a2a3");
            battleShip.Length = 6;
            Assert.AreEqual(String.Join("", battleShip.ShipSlots), "a1a2a3" );

        }



    }
}
