using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game variables
            bool turn = true;
            bool win = false;
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
                // Checking for a win
                // top row
                if (gameBoard[0] != " " && gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2])
                {
                    win = true;
                    Console.WriteLine(gameBoard[0] + " Wins!");
                    goto Win;
                }
                // middle row
                else if (gameBoard[3] != " " && gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5])
                {
                    win = true;
                    Console.WriteLine(gameBoard[3] + " Wins!");
                    goto Win;
                }
                // bottom row
                else if (gameBoard[6] != " " && gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8])
                {
                    win = true;
                    Console.WriteLine(gameBoard[6] + " Wins!");
                    goto Win;
                }
                // left column
                else if (gameBoard[0] != " " && gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6])
                {
                    win = true;
                    Console.WriteLine(gameBoard[0] + " Wins!");
                    goto Win;
                }
                // middle column
                else if (gameBoard[1] != " " && gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])
                {
                    win = true;
                    Console.WriteLine(gameBoard[1] + " Wins!");
                    goto Win;
                }
                // right column
                else if (gameBoard[2] != " " && gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])
                {
                    win = true;
                    Console.WriteLine(gameBoard[2] + " Wins!");
                    goto Win;
                }
                // diagonal from top left
                else if (gameBoard[0] != " " && gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])
                {
                    win = true;
                    Console.WriteLine(gameBoard[0] + " Wins!");
                    goto Win;
                }
                else if (gameBoard[2] != " " && gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])
                {
                    win = true;
                    Console.WriteLine(gameBoard[2] + " Wins!");
                    goto Win;
                }
                else if (gameBoard[i] == " ")
                {
                    if (turn)
                    {
                        Console.WriteLine("It is O's turn.");
                    }
                    else
                    {
                        Console.WriteLine("It is X's turn.");
                    }
                    PlayerMove();
                    goto Start;
                }
            }
            Console.WriteLine("Draw!");
            Win:
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
            }

            // Inputs the player's move
            void PlayerMove()
            {
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
                //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                void Grid(string mark)
                {
                Start2:
                    string move = Console.ReadLine();
                    switch (move.ToLower())
                    {
                        case "a1":
                            if (gameBoard[0] == " ")
                            {
                                gameBoard[0] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "a2":
                            if (gameBoard[1] == " ")
                            {
                                gameBoard[1] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "a3":
                            if (gameBoard[2] == " ")
                            {
                                gameBoard[2] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "b1":
                            if (gameBoard[3] == " ")
                            {
                                gameBoard[3] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "b2":
                            if (gameBoard[4] == " ")
                            {
                                gameBoard[4] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "b3":
                            if (gameBoard[5] == " ")
                            {
                                gameBoard[5] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "c1":
                            if (gameBoard[6] == " ")
                            {
                                gameBoard[6] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "c2":
                            if (gameBoard[7] == " ")
                            {
                                gameBoard[7] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        case "c3":
                            if (gameBoard[8] == " ")
                            {
                                gameBoard[8] = mark;
                            }
                            else
                            {
                                Console.WriteLine("That space is taken, please try again");
                                goto Start2;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect format, enter move like this: a1");
                            goto Start2;
                    }
                }

                SetBoard();
            }
        }
    }
}