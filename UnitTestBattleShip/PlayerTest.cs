using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BattleShip.Models;

namespace UnitTestBattleShip
{
    [TestClass]
    public class PlayerTest
    {
       
       

        [TestMethod]
        public void PlayerSetters_NewShip_returnShipObject()
        {
            
            Ship player1Ship = new Ship();
            Player player = new Player();

           
            player.playerShip = player1Ship;


            Assert.AreEqual(player.playerShip, player1Ship);
        }

        [TestMethod]
        public void PlayerSetters_NewGameBoard_returnGameBoardObject()
        {
            GameBoard player1GameBoard = new GameBoard();
            Player player = new Player();

            player.playerBoard = player1GameBoard;

            Assert.AreEqual(player.playerBoard, player1GameBoard);
            

        }



    }
}
