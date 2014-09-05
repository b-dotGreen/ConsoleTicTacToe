using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    class Player
    {
        private string name;
        private string symbol;
        private int playerNumber;
        
        // Gets and sets the name of the player
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        // Gets and sets the symbol the player is using to mark the board
        public string Symbol
        {
            get { return symbol; }

            set { symbol = value; }
        }

        // Gets and sets the player's number in the game (e.g. Payer 1, Player 2)
        public int PlayerNumber
        {
            get { return playerNumber; }

            set { playerNumber = value; }
        }

        // Method that makrs the GameBoard at the desired position. Returns true if move successfully place on the board.
        public bool MarkBoard(GameBoard board, int position)
        {
            string[] marks = board.CurrentLayout.Split('|');

            for (int i=0; i < marks.Length; i++)
            {
                if (position == Int32.Parse(marks[i]))
                {
                    marks[i] = symbol;

                    ReconstructLayout(board, marks);
                    return true;
                }
            }

            return false;
        }

       // Method that reconstructs the board's layout from an array of marks to the string of marks delimited by the pipe character.
       // Returns the board's layout after modified.
       private string ReconstructLayout(GameBoard board, string[] marks)
        {
           board.CurrentLayout = "";
           string lastPostion = marks.Last();

           foreach (string s in marks)
           {
               if (s.Equals(lastPostion))
               {
                   board.CurrentLayout += (s);
               }
               else
               {
                   board.CurrentLayout += (s + "|");
               }
           }

           return board.CurrentLayout;
        }

    }
}
