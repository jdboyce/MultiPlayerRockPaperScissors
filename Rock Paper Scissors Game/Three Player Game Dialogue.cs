using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Three_Player_Game_Dialogue
    {

        public int numberOfHumanPlayers;

        public int winningScoreNumber;


        public void ChooseNumberOfPlayers()
        {
            Console.WriteLine("\nHow many human players will there be? Enter 0, 1, 2, or 3:");

            string howManyPlayers = Console.ReadLine();

            switch (howManyPlayers)
            {
                case ("0"):
                    {
                        numberOfHumanPlayers = 0;
                        ChooseWinningScore();
                        break;
                    }

                case ("1"):
                    {
                        numberOfHumanPlayers = 1;
                        ChooseWinningScore();
                        break;
                    }

                case ("2"):
                    {
                        numberOfHumanPlayers = 2;
                        ChooseWinningScore();
                        break;
                    }

                case ("3"):
                    {
                        numberOfHumanPlayers = 3;
                        ChooseWinningScore();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nPlease enter a valid answer.\n");
                        ChooseNumberOfPlayers();
                        break;
                    }
            }
        }


        public void ChooseWinningScore()
        {
            Console.WriteLine("\nWhat would you like the winning score to be? Enter 1, 3, 5, 7, or 9.");

            string whatIsWinningScore = Console.ReadLine();

            switch (whatIsWinningScore)
            {
                case ("1"):
                    {
                        winningScoreNumber = 1;
                        CreateNewGame();
                        break;
                    }

                case ("3"):
                    {
                        winningScoreNumber = 3;
                        CreateNewGame();
                        break;
                    }

                case ("5"):
                    {
                        winningScoreNumber = 5;
                        CreateNewGame();
                        break;
                    }

                case ("7"):
                    {
                        winningScoreNumber = 7;
                        CreateNewGame();
                        break;
                    }

                case ("9"):
                    {
                        winningScoreNumber = 9;
                        CreateNewGame();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nPlease enter a valid answer.\n");
                        ChooseWinningScore();
                        break;
                    }
            }
        }


        public void CreateNewGame()
        {
            Three_Player_Game_Logic StartNewGame = new Three_Player_Game_Logic(numberOfHumanPlayers, winningScoreNumber);
            StartNewGame.CreatePlayers();
            Console.WriteLine("\n\nAlright, let the game begin!\n\n");
            StartNewGame.PlayGame();
        }
    }
}







