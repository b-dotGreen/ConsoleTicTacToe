using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    class Program
    {
        // The entry point for the program
        static void Main()
        {
            Game game = new Game();

            game.SetupGame();
            game.PlayGame();
        }
    }
}
