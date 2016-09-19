using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Opening_Game_Dialogue
    {
        public void ChooseGameType()
        {
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors!\n" +
                "\nThis game can be played as a two player or three player game, " +
                "with human or computer players, in any combination." +
                "\nFirst, select the number of players you want (either 2 or 3), " +
                "then select the number of human players (remaining\nplayers will be computer players), " +
                "and finally, select the winning score: each round is worth one point. \n\nGood luck!\n"+
                "\nPlease choose the number of players. Enter either 2 or 3:");

            string twoOrThreePlayerGame = Console.ReadLine();

            switch (twoOrThreePlayerGame)
            {
                case ("2"):
                    {
                        Two_Player_Game_Dialogue newGame = new Two_Player_Game_Dialogue();
                        newGame.ChooseNumberOfPlayers();
                        break;
                    }

                case ("3"):
                    {
                        Three_Player_Game_Dialogue newGame = new Three_Player_Game_Dialogue();
                        newGame.ChooseNumberOfPlayers();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nPlease enter a valid answer.\n");
                        ChooseGameType();
                        break;
                    }
            }
        }
    }
}
