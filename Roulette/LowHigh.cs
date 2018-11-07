using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class LowHigh
    {
        public void loHi()
        {
            Table.DrawTable();
            int[] low = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] high = new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on low (1-18) or high (19-36) numbers.        (low/high)");
            Console.Write("You choose: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "low" && low.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "high" && high.Contains(Winning))
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
