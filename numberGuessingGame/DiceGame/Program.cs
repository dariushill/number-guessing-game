using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoint = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++) // loop 10x (each player gets 10 guesses)
            {
                Console.WriteLine("Press any key to role the dice");

                Console.ReadKey();
               
                playerRandomNum = random.Next(1, 7); // generate random number for player range 1-7
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("..."); // 1 sec delay after player random number
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7); // generate random number for AI range 1-7
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum) // conditional to check if player random number is greater than AI random number
                {
                    playerPoints++; // add 1 point if true
                    Console.WriteLine("Player wins this round");
                }
                else if (playerRandomNum < enemyRandomNum) // conditional to check if AI random number is greater than player random number
                {
                    enemyPoint++; // add 1 point if true
                    Console.WriteLine("AI won this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("Player: " + playerPoints); // display player points
                Console.WriteLine("AI: " + enemyPoint); // display AI points
                Console.WriteLine();
            }
           
            if (playerPoints > enemyPoint) // conditional to check if player points is greater than AI points
            {
                Console.WriteLine("You won!!!!");
            }
            else if (playerPoints < enemyPoint) // coniditional to check if AI points is greater than player points
            {
                Console.WriteLine("You lost");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.ReadKey();
        }
    }
}
