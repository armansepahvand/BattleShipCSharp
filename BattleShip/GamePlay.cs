using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BattleShip
{
    //A class to store the methods which will run the game
    class GamePlay : IGamePlay

    {
        //Init two players of type of IPlayer
        IPlayer _player1;
        IPlayer _player2;

        //Init a game board of type of IGameBoard
        IGameBoard _board;

        //Constructor to get the players and the bord;for each of them
        //an object of the type will be injected into the initiated GamePlay object
        public GamePlay(IPlayer player1, IPlayer player2, IGameBoard board)
        {
            _player1 = player1;
            _player2 = player2;
            _board = board;
        }

        //Method to validate the shots from players to be in the board range and of length of 2.
        //It will check if the shot is good or not and print out relative message on console
        private void ValidateShot(List<string> shipSlots)
        {
            while (true)
            {
                Console.WriteLine("Player1_ fire at a slot on player2's board:");
                string player1Shot = Console.ReadLine();

                //Check if the shot is in range of the board
                if (_board.IsShipInRange(player1Shot))
                {
                    //check if the shot is in the other player ship slots if yes removes it from the list
                    //if no print missed message and exits the loop
                    if (shipSlots.IndexOf(player1Shot) >= 0)
                    {
                        shipSlots.Remove(player1Shot);
                        Console.WriteLine("GoodShot Player1");
                    }
                    else { Console.WriteLine("Ooops, You missed"); }

                    break;
                }
                //if the shot is not in the board range chek if the length of the shot is not 2 characters
                //and ask the player to correct their answer
                else if (player1Shot.Count() != 2)
                {
                    Console.WriteLine("please type exactly 2 characters for your shot:");

                //if the shot is not in the board range but the length of the shot is  2 characters
                // check the order of the characters and ask the player to correct their answer
                }
                else if (Regex.IsMatch(player1Shot.Substring(0, 1), @"^[a-zA-Z]+$") && Regex.IsMatch(player1Shot.Substring(1, 1), @"^\d$")) 
                {
                    Console.WriteLine("please place your shot in the range of the board(width:a-h, height:1-8)");
                }
                //If non of the above cases are valid the shot is out of the board range.Ask the player to correct their answer.
                else
                {
                    Console.WriteLine("please type in a strin of 2 characters in the order of letter and number Ex:b2");
                }


            }
        }

        //Method to ask the players to place their ships on the board
        public string GetShip(string player)
        {
            //init the playerShip string
            string playerShip;
            Console.WriteLine(player+"_ Plaese Place your ship");

            //while loop that validates the answers of the players and will stop as soon as the player 
            //types in the correct sequence of the characters for the ship
            while (true)
            {
                playerShip = Console.ReadLine();
                if (!_board.IsShipInRange(playerShip)  )
                {
                    Console.WriteLine("please place your ship in the range of the board(width:a-h, height:1-8):");
                    
                }else if (playerShip.Count() != 6)
                {
                    Console.WriteLine("please select exactly 3 slots (6 characters) for your ship:");
                }
                else
                {
                    break;
                }
                
            }
            return playerShip;
        }

        /*Method to ask players to input their shots it will validate the inputs to be in the board range and
        of length of 2. it will check if the shot is good or not and print out relative message on console.
        If each of the players sink the others player's ship or they end in a draw it will print the results*/
        public void PlayTheGame()
        {
            //Get the ship slots for each player
            List<string> player1ShipSlots = _player1.playerShip.GetShipSlots();
            List<string> player2ShipSlots = _player2.playerShip.GetShipSlots();

            while (true)
            {
                //Validate the shots and check if they hit the target or not 
                //and display the result of each shot
                ValidateShot(player2ShipSlots);
                ValidateShot(player1ShipSlots);

                //If player1 ship has no slots left but the ship of player2 has at least one slot left
                //Player2 is the winer
                if (player1ShipSlots.Count() == 0 && player2ShipSlots.Count() != 0)
                {
                    Console.WriteLine("Player2 Won the game");
                    break;
                }
                //If player2 ship has no slots left but the ship of player1 has at least one slot left
                //Player1 is the winer
                else if (player2ShipSlots.Count() == 0 && player1ShipSlots.Count() != 0)
                {
                    Console.WriteLine("Player1 Won the game");
                    break;
                }
                //If both ships are destroyed the result is a draw
                else if (player1ShipSlots.Count() == 0 && player2ShipSlots.Count() == 0)
                {
                    Console.WriteLine("Wow, its a draw");
                    break;
                }
            }
        }
    }
}
