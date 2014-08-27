using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    public abstract class GameBoard
    {
        protected string currentLayout;
        protected bool isFull;

        // Gets and Sets the currentLayout of the board
        public string CurrentLayout
        {
            get { return currentLayout; }
            set { currentLayout = value; }
        }

        // Gets the status of the board, whether or not all moves have been made
        public bool IsFull
        {
            get { return isFull; }
        }

        public void PrintBoard();
    }
}
