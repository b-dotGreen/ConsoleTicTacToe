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
            // ALL CODE UNDER THIS POINT IS CURRENTLY THERE FOR DEBUGGING PURPOSES ONLY
            StandardBoard myBoard = new StandardBoard();
            myBoard.PrintBoard();
            Console.ReadKey();
        }
    }
}
