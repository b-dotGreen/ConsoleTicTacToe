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

        public abstract bool IsFull();
        public abstract void PrintBoard();
        public abstract string CheckForWinner(bool boardIsFull);
    }
}
