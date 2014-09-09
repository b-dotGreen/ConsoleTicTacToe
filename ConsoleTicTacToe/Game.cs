using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTicTacToe
{
    class Game
    {
        private GameBoard board;
        private Player player1 = new Player("Player1", "X", 1);
        private Player player2 = new Player("Player2", "O", 2);
        private int firstMove = 0;

        /* PUBLIC METHODS */
       public  void SetupGame()
        {
            DisplayWelcomeMessage(); 
            SelectBoardType();
            NamePlayers();
            SelectSymbol();
            firstMove = CoinToss();
        }
        
        public void PlayGame()
        {      
            string winnerSymbol = "default";
            bool toggleTurn = true;

            board.PrintBoard();
                
            if (player1.PlayerNumber == firstMove)
            {
                toggleTurn = false;
            }
            
            while (!board.IsFull())
            {
                if (toggleTurn)
                {
                    PlayerMove(player1);
                    toggleTurn = false;
                }
                else
                {
                    PlayerMove(player2);
                    toggleTurn = true;
                }

                board.PrintBoard();
                winnerSymbol = board.CheckForWinner(board.IsFull());

                if(winnerSymbol != "CONTINUE")
                {
                    break;
                }
            }

            DeclareWinner(winnerSymbol);
            GameOver();
        }

        /* PRIVATE METHODS */
        private void PlayerMove(Player player)
        {
            string playerMarkPosition;
            bool moveValid = false;

            while (!moveValid)
            {
                System.Console.WriteLine("\n" + player.Name + " what is your move?");
                playerMarkPosition = System.Console.ReadLine();

                if (playerMarkPosition == "1" || playerMarkPosition == "2" || playerMarkPosition == "3" || playerMarkPosition == "4" || playerMarkPosition == "5" || playerMarkPosition == "6" || playerMarkPosition == "7" || playerMarkPosition == "8" || playerMarkPosition == "9")
                {
                    moveValid = player.MarkBoard(board, Int32.Parse(playerMarkPosition));

                    if (!moveValid)
                    {
                        System.Console.WriteLine("\nInvalid move");
                    }
                }
                else
                {
                    moveValid = false;
                    System.Console.WriteLine("\nInvalid move");
                }
            }
        }

        private void DeclareWinner(string winnerSymbol)
        {
            if (winnerSymbol == player1.Symbol)
            {
                System.Console.WriteLine("\n" + player1.Name + " is the winner!");
            }
            else  if (winnerSymbol == player2.Symbol)
            {
                System.Console.WriteLine("\n" + player2.Name + " is the winner!");
            }
            else
            {
                // Cat's game
                System.Console.WriteLine("\n" + winnerSymbol);
            }
        }

        private int CoinToss()
        {
            Random randomNumber = new Random();

            System.Console.WriteLine("\n\nWho will go first...?");
            
            if (randomNumber.Next(101) % 2 == 0)
            {
                System.Console.WriteLine(player1.Name + " will go first!");
                return 1;
            }
            else
            {
                System.Console.WriteLine(player2.Name + " will go first!");
                return 2;
            }

        }

        private void GameOver()
        {
            System.Console.WriteLine("\n\n ***** GAME OVER *****");
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }

        private void NamePlayers()
        {
            System.Console.WriteLine("\n\nPlease enter the name for Player 1:");
            player1.Name = System.Console.ReadLine();

            System.Console.WriteLine("Please enter the name for Player 2:");
            player2.Name = System.Console.ReadLine();

        }

        private void SelectBoardType()
        {
            string userSelection = "0";
            bool continueLoop = true;

            while (continueLoop)
            {
                System.Console.WriteLine("\nPlease Select the type of board to play on:");
                System.Console.WriteLine("(1) Standard Board");
                System.Console.WriteLine("(2) Bomb Board");
                System.Console.Write("Your selection: ");

                userSelection = System.Console.ReadLine();

                if (userSelection == "1")
                {
                    board = new StandardBoard();
                    continueLoop = false;
                }
                else if (userSelection == "2")
                {
                    // NOT YET IMPLEMENTED
                    System.Console.WriteLine("SORRY, THIS ISN'T INCLUDED YET. WILL START GAME WITH A STANDARD BOARD.");
                    board = new StandardBoard();
                    continueLoop = false;
                }
                else
                {
                    System.Console.WriteLine("\n\nInvalid selection");
                }
             
            }
        }

        private void SelectSymbol()
        {
            do
            {
                System.Console.WriteLine("\n\nPlease enter the game marker symbol used by Player 1:");
                player1.Symbol = System.Console.ReadLine();

                if (player1.Symbol.Length > 1 || player1.Symbol == "1" || player1.Symbol == "2" || player1.Symbol == "3" || player1.Symbol == "4" || player1.Symbol == "5" || player1.Symbol == "6" || player1.Symbol == "7" || player1.Symbol == "8" || player1.Symbol == "9")
                {
                    System.Console.WriteLine("A player's marker symbol may only be one character in length and may not be a number");
                }
            } while (player1.Symbol.Length > 1 || player1.Symbol == "1" || player1.Symbol == "2" || player1.Symbol == "3" || player1.Symbol == "4" || player1.Symbol == "5" || player1.Symbol == "6" || player1.Symbol == "7" || player1.Symbol == "8" || player1.Symbol == "9");

            do
            {
                System.Console.WriteLine("\n\nPlease enter the game marker symbol used by Player 2:");
                player2.Symbol = System.Console.ReadLine();

                if (player2.Symbol.Length > 1 || player2.Symbol == "1" || player2.Symbol == "2" || player2.Symbol == "3" || player2.Symbol == "4" || player2.Symbol == "5" || player2.Symbol == "6" || player2.Symbol == "7" || player2.Symbol == "8" || player2.Symbol == "9")
                {
                    System.Console.WriteLine("A Player's marker symbol may only be one character in length and may not be a number");
                }
            } while (player2.Symbol.Length > 1 || player2.Symbol == "1" || player2.Symbol == "2" || player2.Symbol == "3" || player2.Symbol == "4" || player2.Symbol == "5" || player2.Symbol == "6" || player2.Symbol == "7" || player2.Symbol == "8" || player2.Symbol == "9");
        }

        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("\n-------Welcome to Tic-Tac-Toe!-------");
            System.Console.WriteLine("\n Let's prepare your game...");
        }
    }
}
