using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class BattleShipTest
    {
 
        [TestMethod]
        public void GetShipSlots_ValueForShipString_ReturnTheSameValue()
        {
            Ship battleShip = new Ship();
            battleShip.ShipString = "a1a2a3";
            Assert.AreEqual(String.Join("", battleShip.GetShipSlots()), "a1a2a3" );

        }

        [TestMethod]
        public void ShipSetters_ValueForLength_ReturnTheSameValue()
        {
            Ship battleShip = new Ship();
            battleShip.Length = 6;
            Assert.AreEqual(battleShip.Length, 6);

        }

        [TestMethod]
        public void ShipSetters_ValueForShipString_ReturnTheSameValue()
        {
            Ship battleShip = new Ship();
            battleShip.ShipString = "a1b2c3";
            Assert.AreEqual(battleShip.ShipString, "a1b2c3");

        }



    }
}
