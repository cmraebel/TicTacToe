using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game variables
            bool turn = true;
            string[] gameBoard = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

            // Intro text
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("To make a move, enter the space you wish to play in like this: a1");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            // Sets the board for the first move
            SetBoard();

            // Game loop
            Start:
            // Checks for an empty space on the board to see if the game should keep going
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] == " ")
                {
                    PlayerMove();
                    goto Start;
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            // Game methods

            // Clears the console and sets the game board
            void SetBoard()
            {
                Console.Clear();

                Console.WriteLine(
                    "A [" + gameBoard[0] + "] [" + gameBoard[1] + "] [" + gameBoard[2] + "]\n" +
                    "B [" + gameBoard[3] + "] [" + gameBoard[4] + "] [" + gameBoard[5] + "]\n" +
                    "C [" + gameBoard[6] + "] [" + gameBoard[7] + "] [" + gameBoard[8] + "]\n" +
                    "   1   2   3"
                    );

                Console.WriteLine();


                for (int i = 0; i < gameBoard.Length; i++)
                {
                    if (gameBoard[i] == " ")
                    {
                        if (turn)
                        {
                            Console.WriteLine("It is O's turn.");
                        }
                        else
                        {
                            Console.WriteLine("It is X's turn.");
                        }
                        break;
                    }
                }
            }

            // Inputs the player's move
            void PlayerMove()
            {
                string move = Console.ReadLine();

                if (turn)
                {
                    Grid("O");
                    turn = false;
                }
                else
                {
                    Grid("X");
                    turn = true;
                }

                // Sets the selected grid space to the player's mark
                void Grid(string mark)
                {
                    switch (move.ToLower())
                    {
                        case "a1":
                            gameBoard[0] = mark;
                            break;
                        case "a2":
                            gameBoard[1] = mark;
                            break;
                        case "a3":
                            gameBoard[2] = mark;
                            break;
                        case "b1":
                            gameBoard[3] = mark;
                            break;
                        case "b2":
                            gameBoard[4] = mark;
                            break;
                        case "b3":
                            gameBoard[5] = mark;
                            break;
                        case "c1":
                            gameBoard[6] = mark;
                            break;
                        case "c2":
                            gameBoard[7] = mark;
                            break;
                        case "c3":
                            gameBoard[8] = mark;
                            break;
                        default:
                            break;
                    }
                }


                
                SetBoard();
            }
        }
    }
}
