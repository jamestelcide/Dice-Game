using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//V2
namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int opponentPoints = 0;

            Console.WriteLine("Welcome to the Dice Game!");
            Console.WriteLine("Win 10 rounds by rolling higher than your opponent.");
            Console.WriteLine();

            Game(playerPoints, opponentPoints);
            Console.ReadKey();
        }

        static void Game(int playerPoints, int opponentPoints)
        {
            int playerRandomNum;
            int opponentRandomNum;

            Random random = new Random();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Round " + i);
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                Console.WriteLine();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
                System.Threading.Thread.Sleep(1000);

                opponentRandomNum = random.Next(1, 7);
                Console.WriteLine("Opponent rolled a " + opponentRandomNum);

                Console.WriteLine();

                if (playerRandomNum > opponentRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this round!");
                }
                else if (playerRandomNum < opponentRandomNum)
                {
                    opponentPoints++;
                    Console.WriteLine("Opponent wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine();
                Console.WriteLine("::SCORE:: YOU: " + playerPoints +
                    " | OPPONENT: " + opponentPoints);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine(Results(playerPoints, opponentPoints));
        }

        static String Results(int playerPoints, int opponentPoints)
        {
            if (playerPoints > opponentPoints)
            {
                return "You Win!";
            }
            else if (playerPoints < opponentPoints)
            {
                return "You Lose!";
            }
            else
            {
                return "ITS A DRAW!";
            }
        }

    }
}
