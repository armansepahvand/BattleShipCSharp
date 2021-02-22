using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip.Models
{
    /*A class to create the battleship objects by getting the 
    ship placement on the board as a string Ex:"a1a2a3".The ship's length is set to 3 as default */
    public class Ship : IShip
    {
        public string ShipString { get; set; } = "b1b2b3";
        public int Length { get; set; } = 3;


        //Method to convert the ship string Ex:"a1a2a3" and convert it to
        //a list of slots of length of 2 characters Ex:{"a1","a2","a3"}
        public List<string> GetShipSlots()
        {
            return GameBoard.Split(ShipString, 2).ToArray().ToList();
        }
    }
}
