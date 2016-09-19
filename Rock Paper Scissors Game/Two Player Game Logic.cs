using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Two_Player_Game_Logic
    {

        Player player1;

        Player player2;

        public int winningScoreNumber;

        public int numberOfHumanPlayers;


        public Two_Player_Game_Logic(int passedNumberOfHumanPlayers, int passedWinningScoreNumber)
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
            }

            else if (numberOfHumanPlayers == 1)
            {
                Player.Human newPlayer1 = new Player.Human();
                player1 = newPlayer1;
                ChooseNamePlayer1();
                Player.Computer newPlayer2 = new Player.Computer();
                player2 = newPlayer2;
                player2.name = "Computer";
            }

            else if (numberOfHumanPlayers == 2)
            {
                Player.Human newPlayer1 = new Player.Human();
                player1 = newPlayer1;
                ChooseNamePlayer1();
                Player.Human newPlayer2 = new Player.Human();
                player2 = newPlayer2;
                ChooseNamePlayer2();
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


        public void PlayGame()
        {
            while (player1.points < winningScoreNumber && player2.points < winningScoreNumber)
            {
                player1.PlayerInput();

                player2.PlayerInput();

                GameLogic();
            }

            if (player1.points > player2.points)
            {
                Console.WriteLine("\n{0} is the winner!\n\n", player1.name);
            }

            else
            {
                Console.WriteLine("\n{0} is the winner!\n\n", player2.name);
            }
        }


        public void GameLogic()
        {

            if ((player2.inputAsInt) % 3 + 1 == player1.inputAsInt)
            {
                player1.AddPoint();
                Console.WriteLine("\n{0} chose {1}, and {2} chose {3}.\n\nThe score is:   {0}: {4}   |   {2}: {5}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player1.points, player2.points);
            }

            else if ((player1.inputAsInt) % 3 + 1 == player2.inputAsInt)
            {
                player2.AddPoint();
                Console.WriteLine("\n{0} chose {1}, and {2} chose {3}.\n\nThe score is:   {0}: {4}   |   {2}: {5}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player1.points, player2.points);
            }

            else
            {
                Console.WriteLine("\nIt's a draw. {0} and {2} both chose {1}.\n\nThe score is:   {0}: {4}   |   {2}: {5}\n", player1.name, player1.inputAsString, player2.name, player2.inputAsString, player1.points, player2.points);

            }
        }
    }
}
