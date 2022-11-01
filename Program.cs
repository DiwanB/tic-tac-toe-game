using System;

// Tic-Tac-Toe Program version 0.1 by Diwan Bhangal. All Rights Reserved.

namespace FPT
{
    class Program
    {
        static string[] NRV = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Board Positions
        static void ClearGRD() //Method used to clear the board
        {
            for (int i = 1; i < 10; i++)
            {
                NRV[i] = i.ToString();
            }
        }
        static void GRD() //Method used to draw the board
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", NRV[1], NRV[2], NRV[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", NRV[4], NRV[5], NRV[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", NRV[7], NRV[8], NRV[9]);
        }

        static bool winCheck() //Checks if the game is won by either player
        {
            if (NRV[1] == "O" && NRV[2] == "O" && NRV[3] == "O")
            {
                return true;
            }
            else if (NRV[4] == "O" && NRV[5] == "O" && NRV[6] == "O")
            {
                return true;
            }
            else if (NRV[7] == "O" && NRV[8] == "O" && NRV[9] == "O")
            {
                return true;
            }

            else if (NRV[1] == "O" && NRV[5] == "O" && NRV[9] == "O")                           // I got bored.
                                                                                                //    __      _
            {                                                                                   //  o'')}____//
                return true;                                                                    //   `_/      )
            }                                                                                   //   (_(_/-(_/
            else if (NRV[7] == "O" && NRV[5] == "O" && NRV[3] == "O")                           // what the dog doin
            {
                return true;
            }

            else if (NRV[1] == "O" && NRV[4] == "O" && NRV[7] == "O")
            {
                return true;
            }
            else if (NRV[2] == "O" && NRV[5] == "O" && NRV[8] == "O")
            {
                return true;
            }
            else if (NRV[3] == "O" && NRV[6] == "O" && NRV[9] == "O")
            {
                return true;
            }

            if (NRV[1] == "X" && NRV[2] == "X" && NRV[3] == "X")
            {
                return true;
            }
            else if (NRV[4] == "X" && NRV[5] == "X" && NRV[6] == "X")
            {
                return true;
            }
            else if (NRV[7] == "X" && NRV[8] == "X" && NRV[9] == "X")
            {
                return true;
            }

            else if (NRV[1] == "X" && NRV[5] == "X" && NRV[9] == "X")
            {
                return true;
            }
            else if (NRV[7] == "X" && NRV[5] == "X" && NRV[3] == "X")
            {
                return true;
            }

            else if (NRV[1] == "X" && NRV[4] == "X" && NRV[7] == "X")
            {
                return true;
            }
            else if (NRV[2] == "X" && NRV[5] == "X" && NRV[8] == "X")
            {
                return true;
            }
            else if (NRV[3] == "X" && NRV[6] == "X" && NRV[9] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            char replay = 'Y';
            string player1, player2;
            int turn = 1, choice = 0, score1 = 0, score2 = 0; //For some reason, choice, score1, and score2 did NOT have pre-assigned values of 0, so I had to set them to 0. I hate it.
            Random name = new Random(); //Random Title Generator
            string[] gameName = new string[5] { "THE KING OF TIC TAC TOURNAMENT 7", "TIC TAC... actually just go play TrackMania Nations Forever instead", "THE KING OF FIGHTERS 2002 UNLIMITED MATC-I MEAN TIC TAC TOE", "TIC TAC COPE", "TIC TAC TOE" };
            

            Console.WriteLine("WELCOME TO {0}", gameName[name.Next(0, 4)]); //Outputs a random title from the pool of titles I created above
            Console.WriteLine();
            Console.Write("Enter Player 1's Name: ");
            player1 = Console.ReadLine();
            Console.Write("Enter Player 2's Name: ");
            player2 = Console.ReadLine();
            while (replay == 'Y')
            {
                bool win = false, inPlay = true, validInput = false;
                Console.WriteLine("'{0}' IS O. '{1}' IS X. THE WHEEL OF FATE IS TURNING. DUEL 1... you know what just play the game", player1, player2);
                Console.WriteLine();
                Console.WriteLine("{0} gets to move first.", player1);
                System.Threading.Thread.Sleep(6000); //Gives the user time to read what was just outputted, before clearing the screen to draw the board
                Console.Clear();

                while (inPlay == true) //Checks if the game is in play
                {
                    while (win == false) //Checks if someone has won
                    {
                        Console.WriteLine("SCORE: {0} - {1} POINT(S). {2} - {3} POINT(S).", player1, score1, player2, score2);
                        GRD();
                        if (turn == 1)
                        {
                            Console.WriteLine("{0}, PLACE YOUR O.", player1);
                        }
                        if (turn == 2)
                        {
                            Console.WriteLine("{0}, PLACE YOUR X.", player2);
                        }

                        while (validInput == false) //Asks the user to choose a position on the board
                        {
                            Console.WriteLine("CHOOSE A POSITION TO TAKE: ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice > 0 && choice < 10)
                            {
                                validInput = true;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        validInput = false;

                        if (turn == 1) //Makes sure the position is not already occupied, if it is then the user selects another position, if it isn't then a piece is placed onto the board at the specified position
                        {
                            if (NRV[choice] == "X")
                            {
                                Console.WriteLine("THIS POSITION HAS ALREADY BEEN TAKEN BY {0}. TRY AGAIN.", player2);
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                continue;
                            }
                            if (NRV[choice] == "O")
                            {
                                Console.WriteLine("YOU HAVE ALREADY PLACED AN O THERE. TRY AGAIN.");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                NRV[choice] = "O";
                            }
                        }
                        if (turn == 2) //What was just done above but for player 2
                        {
                            if (NRV[choice] == "O")
                            {
                                Console.WriteLine("THIS POSITION HAS ALREADY BEEN TAKEN BY {0}. TRY AGAIN.", player1);
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                continue;
                            }
                            if (NRV[choice] == "X")
                            {
                                Console.WriteLine("YOU HAVE ALREADY PLACED AN X THERE. TRY AGAIN.");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                NRV[choice] = "X";
                            }
                        }

                        win = winCheck();
                        
                        if (win == false) //Keeps switching turns if nobody has won
                        {
                            if (turn == 1)
                            {
                                turn = 2;
                            }
                            else if (turn == 2)
                            {
                                turn = 1;
                            }
                            Console.Clear();
                        }
                    }
                    Console.Clear();
                    GRD();
                    ClearGRD();

                    if (win == true) //Player 1 Victory text, scoreboard, replay option select
                    {
                        if (turn == 1)
                        {
                            score1++;
                            Console.WriteLine("{0} HAS EMERGED VICTORIOUS.", player1);
                            Console.WriteLine("SCORE: {0} - {1} POINT(S), {2} - {3} POINT(S).", player1, score1, player2, score2);
                            Console.WriteLine("PLAY AGAIN? (Y/N)");
                            replay = Convert.ToChar(Console.ReadLine());
                            if (replay == 'Y')
                            {
                                Console.WriteLine("HERE COMES DAREDEVIL");
                                System.Threading.Thread.Sleep(3000);
                                win = false;
                                Console.Clear();
                            }
                            if (replay == 'N')
                            {
                                Console.WriteLine("WISE CHOICE.");
                                System.Threading.Thread.Sleep(3000);
                                inPlay = false;
                                break;
                            }
                        }
                        if (turn == 2) //Player 2 Victory text, scoreboard, replay option select
                        {
                            score2++;
                            Console.WriteLine("{0} HAS EMERGED VICTORIOUS.", player2);
                            Console.WriteLine("SCORE: {0} - {1} POINT(S), {2} - {3} POINT(S).", player1, score1, player2, score2);
                            Console.WriteLine("PLAY AGAIN? (Y/N)");
                            replay = Convert.ToChar(Console.ReadLine());
                            if (replay == 'Y')
                            {
                                Console.WriteLine("HERE COMES DAREDEVIL");
                                System.Threading.Thread.Sleep(3000);
                                win = false;
                                Console.Clear();
                            }
                            if (replay == 'N')
                            {
                                Console.WriteLine("WISE CHOICE.");
                                System.Threading.Thread.Sleep(3000);
                                inPlay = false;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
