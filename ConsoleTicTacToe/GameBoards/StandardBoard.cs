using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    class StandardBoard : GameBoard
    {
        private const int MAX_MARKS_PER_ROW = 3;

        public StandardBoard()
        {
            this.isFull = false;
            this.currentLayout = "1|2|3|4|5|6|7|8|9";        
        }

        public override void PrintBoard()
        {
            int printCount = 0;
            string[] marks = currentLayout.Split('|');
            
            // Create two blank lines for easier readability
            System.Console.WriteLine();
            System.Console.WriteLine();

            // Loop through the marks in order to print them as they would appear on an average tic-tac-toe board
            foreach (string s in marks)
            {
                System.Console.Write("|{0}", s);
                printCount++;                
                
                // Move the printout to a new line to continue the grid
                if (printCount % MAX_MARKS_PER_ROW == 0)
                {
                    System.Console.Write("|\n");
                }
            }
        }
        
        public override string CheckForWinner()
        {
            string[] marks = currentLayout.Split('|');

            // Check rows for winner
            if (ThreeStringCompare(marks[0], marks[1], marks[2]))
            {
                return marks[0];
            }
            else if (ThreeStringCompare(marks[3], marks[4], marks[5]))
            {
                return marks[3];
            }
            else if (ThreeStringCompare(marks[6], marks[7], marks[8]))
            {
                return marks[6];
            }
            // Check columns for winner
            else if (ThreeStringCompare(marks[0], marks[3], marks[6]))
            {
                return marks[0];
            }
            else if (ThreeStringCompare(marks[1], marks[4], marks[7]))
            {
                return marks[1];
            }
            else if (ThreeStringCompare(marks[2], marks[5], marks[8]))
            {
                return marks[2];
            }
            // Check diagonals for winner
            else if (ThreeStringCompare(marks[0], marks[4], marks[8]))
            {
                return marks[0];
            }
            else if (ThreeStringCompare(marks[6], marks[4], marks[2]))
            {
                return marks[6];
            }
            // Otherwise it's a tie game
            else
            {
                return "NOBODY";
            }
        }

        private bool ThreeStringCompare(string s1, string s2, string s3)
        {
            if ((s1==s2) && (s1==s3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
