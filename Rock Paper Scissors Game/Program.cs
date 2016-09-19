using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Opening_Game_Dialogue startGame = new Opening_Game_Dialogue();

            startGame.ChooseGameType();

            Console.ReadLine();
        }
    }
}
