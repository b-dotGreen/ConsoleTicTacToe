using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    class StandardBoard : GameBoard
    {
        public StandardBoard()
        {
            isFull = false;
            currentLayout = "1|2|3|4|5|6|7|8|9";        
        }

        public override void PrintBoard()
        {
            string[] moves = currentLayout.Split('|');

            // Create a blank line for easier readability
            System.Console.WriteLine();

            int count = 0;
            foreach (string s in moves)
            {
                System.Console.Write("|{0}", s);
                count++;                
                
                // Moves the printout to a new line to continue the grid
                if (count % 3 == 0)
                {
                    System.Console.Write("|\n");
                }
            }
        }
        
        public char CheckForWinner(string layout)
        {
            // implement here
            return 'a'; //placeholder
        }
    }
}
