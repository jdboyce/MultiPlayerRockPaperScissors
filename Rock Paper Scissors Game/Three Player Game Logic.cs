using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Three_Player_Game_Logic
    {

        Player player1;

        Player player2;

        Player player3;

        Player finalistPlayer1;

        Player finalistPlayer2;

        public int winningScoreNumber;

        public int numberOfHumanPlayers;

  
        public Three_Player_Game_Logic(int passedNumberOfHumanPlayers, int passedWinningScoreNumber)
        {
            this.numberOfHumanPlayers = passedNumberOfHumanPlayers;
            this.winningScoreNumber = passedWinningScoreNumber;
        }


        public void CreatePlayers()
        {
            if (numberOfHumanPlayers == 0)
            {
                Player.Computer newPlayer1 = new Player.Computer();
                player1 = newPlayer1;
                player1.name = "Computer 1";
                Player.Computer newPlayer2 = new Player.Computer();
                player2 = newPlayer2;
                player2.name = "Computer 2";
                Player.Computer newPlayer3 = new Player.Computer();
                player3 = newPlayer3;
                player3.name = "Computer 3";
            }

            else if (numberOfHumanPlayers == 1)
            {
                Player.Human newPlayer1 = new Player.Human();
                player1 = newPlayer1;
                ChooseNamePlayer1();
                Player.Computer newPlayer2 = new Player.Computer();
                player2 = newPlayer2;
                player2.name = "Computer 1";
                Player.Computer newPlayer3 = new Player.Computer();
                player3 = newPlayer3;
                player3.name = "Computer 2";
            }

            else if (numberOfHumanPlayers == 2)
            {
                Player.Human newPlayer1 = new Player.Human();
                player1 = newPlayer1;
                ChooseNamePlayer1();
                Player.Human newPlayer2 = new Player.Human();
                player2 = newPlayer2;
                ChooseNamePlayer2();
                Player.Computer newPlayer3 = new Player.Computer();
                player3 = newPlayer3;
                player3.name = "Computer";
            }

            else if (numberOfHumanPlayers == 3)
            {
                Player.Human newPlayer1 = new Player.Human();
                player1 = newPlayer1;
                ChooseNamePlayer1();
                Player.Human newPlayer2 = new Player.Human();
                player2 = newPlayer2;
                ChooseNamePlayer2();
                Player.Human newPlayer3 = new Player.Human();
                player3 = newPlayer3;
                ChooseNamePlayer3();
            }
        }


        public void ChooseNamePlayer1()
        {
            Console.WriteLine("\nPlease enter a name for Player 1:");
            player1.name = Console.ReadLine();
        }


        public void ChooseNamePlayer2()
        {
            Console.WriteLine("\nPlease enter a name for Player 2:");
            player2.name = Console.ReadLine();
        }


        public void ChooseNamePlayer3()
        {
            Console.WriteLine("\nPlease enter a name for Player 2:");
            player3.name = Console.ReadLine();
        }


        public void PlayGame()
        {
            while (player1.points < winningScoreNumber && player2.points < winningScoreNumber && player3.points < winningScoreNumber)
            {
                player1.PlayerInput();

                player2.PlayerInput();

                player3.PlayerInput();

                GameLogic();
            }

            DetermineWinner();
        }


        public void GameLogic()
        {
            if (player1.inputAsInt == player2.inputAsInt && player2.inputAsInt == player3.inputAsInt && player3.inputAsInt == player1.inputAsInt)
            {
                Console.WriteLine("\nIt's a draw. {0}, {1}, and {2} all chose {3}.\n\nThe score is:   {0}: {4}   |   {1}: {5}   |   {2}: {6}\n", player1.name, player2.name, player3.name, player1.inputAsString, player1.points, player2.points, player3.points);
            }

            else if (player1.inputAsInt != player2.inputAsInt && player2.inputAsInt != player3.inputAsInt && player3.inputAsInt != player1.inputAsInt)
            {
                Console.WriteLine("\nIt's a draw. {0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
            }


            else if ((player2.inputAsInt) % 3 + 1 == player1.inputAsInt)
            {
                if (player1.inputAsInt == player3.inputAsInt)
                {
                    player1.AddPoint();
                    player3.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }

                else
                {
                    player1.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }
            }

            else if ((player3.inputAsInt) % 3 + 1 == player2.inputAsInt)
            {
                if (player2.inputAsInt == player1.inputAsInt)
                {
                    player2.AddPoint();
                    player1.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }

                else
                {
                    player2.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }
            }

            else if ((player1.inputAsInt) % 3 + 1 == player3.inputAsInt)
            {
                if (player3.inputAsInt == player2.inputAsInt)
                {
                    player3.AddPoint();
                    player2.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }

                else
                {
                    player3.AddPoint();
                    Console.WriteLine("\n{0} chose {1}, {2} chose {3}, and {4} chose {5}.\n\nThe score is:   {0}: {6}   |   {2}: {7}   |   {4}: {8}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player3.name, player3.inputAsString, player1.points, player2.points, player3.points);
                }
            }
        }


        public void DetermineWinner()
        {
            if (player1.points > player2.points)
            {
                if (player1.points > player3.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player1.name);
                }

                else if (player1.points < player3.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player3.name);
                }

                else
                {
                    finalistPlayer1 = player1;
                    finalistPlayer2 = player3;
                    Console.WriteLine("\n {1} has been defeated. {0} and {2}, it's time for a sudden death match!\n", player1.name, player2.name, player3.name);
                    SuddenDeath();
                }
            }

            else if (player2.points > player3.points)
            {
                if (player2.points > player1.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player2.name);
                }

                else if (player2.points < player1.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player1.name);
                }

                else
                {
                    finalistPlayer1 = player2;
                    finalistPlayer2 = player1;
                    Console.WriteLine("\n {2} has been defeated. {0} and {1}, it's time for a sudden death match!\n", player1.name, player2.name, player3.name);
                    SuddenDeath();
                }
            }

            else if (player3.points > player1.points)
            {
                if (player3.points > player2.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player3.name);
                }

                else if (player3.points < player2.points)
                {
                    Console.WriteLine("\n{0} is the winner!\n", player2.name);
                }

                else
                {
                    finalistPlayer1 = player3;
                    finalistPlayer2 = player2;
                    Console.WriteLine("\n{0} has been defeated. {1} and {2}, it's time for a sudden death match!\n", player1.name, player2.name, player3.name);
                    SuddenDeath();
                }
            }
        }


        public void SuddenDeath()
        {
            while (finalistPlayer1.points == finalistPlayer2.points)
            {
                finalistPlayer1.PlayerInput();

                finalistPlayer2.PlayerInput();

                SuddenDeathGameLogic();
            }

            if (finalistPlayer1.points > finalistPlayer2.points)
            {
                Console.WriteLine("\n{0} is the winner!\n", finalistPlayer1.name);
            }

            else
            {
                Console.WriteLine("\n{0} is the winner!\n\n", finalistPlayer2.name);
            }
        }


        public void SuddenDeathGameLogic()
        {
            if ((finalistPlayer2.inputAsInt) % 3 + 1 == finalistPlayer1.inputAsInt)
            {
                finalistPlayer1.AddPoint();
                Console.WriteLine("\n{0} chose {1}, and {2} chose {3}.", finalistPlayer1.name, finalistPlayer1.inputAsString, finalistPlayer2.name, finalistPlayer2.inputAsString);
            }

            else if ((finalistPlayer1.inputAsInt) % 3 + 1 == finalistPlayer2.inputAsInt)
            {
                finalistPlayer2.AddPoint();
                Console.WriteLine("\n{0} chose {1}, and {2} chose {3}.", finalistPlayer1.name, finalistPlayer1.inputAsString, finalistPlayer2.name, finalistPlayer2.inputAsString);
            }

            else
            {
                Console.WriteLine("\nIt's a draw. {0} and {1} both chose {2}. Go again!", finalistPlayer1.name, finalistPlayer2.name, finalistPlayer1.inputAsString);
            }
        }
    }
}