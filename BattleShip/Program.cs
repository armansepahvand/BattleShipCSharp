using BattleShip.Models;
using System;


namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init players for the game
            Player player1 = new Player();
            Player player2 = new Player();

            //Init a Board for the game
            GameBoard board = new GameBoard();

            //Pass the players and the board to gamePlay onject
            GamePlay gamePlay = new GamePlay(player1, player2, board);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***All the ships and shot slots selected in this game should be in the game board range\n" +
                "***The boad has a widt of a to h and a hieght of 1 to 8\n" +
                "***An example of input for a ship is: a2b2c2\n" +
                "***An example for a shot is: a2\n");
 
            //Get the ship placement from players
            player1.playerShip.ShipString = gamePlay.GetShip("Player1");
            player2.playerShip.ShipString = gamePlay.GetShip("Player2");

            //Play the Game!!!
            gamePlay.PlayTheGame();
        }
    }
}

