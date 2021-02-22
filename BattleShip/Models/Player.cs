using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip.Models
{
    //A class to create player object that has a battleShipBoard object and a battleShip object
    public class Player : IPlayer
    {
        public IGameBoard playerBoard { get; set; } = new GameBoard();
        public IShip playerShip { get; set; } = new Ship();
    }
}
