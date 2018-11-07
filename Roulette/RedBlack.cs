using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RedBlack
    {
        public void Color()
        {
            Table.DrawTable();
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on red or black numbers.        (red/black)");
            Console.Write("You choose: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "red" && red.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "black" && black.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else
            {
                Console.WriteLine($"You choose: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
                Console.WriteLine("You lose this round, better luck next time.");
            }
        }
    }
}
