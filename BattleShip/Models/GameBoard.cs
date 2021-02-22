using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip.Models
{
    //A class to create the game board with the default width of a to h and height of 8
    public class GameBoard : IGameBoard
    {
        public string Width { get; set; } = "h";
        public ushort Height { get; set; } = 8;



        /*Method to  get a string Ex:"a1a2a3" and chunk size , and convert it to
        /an array of slots of length of given chunk size  Ex:{"a1","a2","a3"} for chunk size of 2*/
        public static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
        public bool IsShipInRange(string shipSlots)
        {
            //Get the shipSlots as a string Ex:"a1a2a3" and convert it to an array
            //of strings with length of 2 EX:{"a1","a2","a3"}
            string[] arrayofSlots = Split(shipSlots, 2).ToArray();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            bool state;
            state = true;

            //Loop over every slot in the arrayOfSlots
            foreach (string slot in arrayofSlots)
            {
                //Convert letter to lowercase to make the function case insensetive
                string lowerCaseWidth = slot[0].ToString().ToLower();

                //Get the index of the horizontal coordinate of slot in the alphabet sequence
                int testWidthIndex = alphabet.IndexOf(lowerCaseWidth);

                //Get the index of Board width in alphabet sequence
                int widthIndex = alphabet.IndexOf(Width);

                //Get the vertical coordinate of the slot
                int testHeight = slot[1];

                /*Check if the slot is in range of the board
                 if any of the slots are out of the board
                 break out of the loop and return false*/
                if (
                  testHeight - 49 >= Height ||
                  testHeight-49<0 ||
                  testWidthIndex > widthIndex ||
                  testWidthIndex < 0
                )
                {
                    state = false;
                    break;
                }
            }
            return state;
        }
    }
}
