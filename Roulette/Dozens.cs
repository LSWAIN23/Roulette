using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Dozens
    {
        public void Doz()
        {
            Table.DrawTable();
            int[] first = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] second = new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            int[] third = new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on first (1-12), second (13-24), or third (25-36).        (first/second/third)");
            Console.Write("You choose: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "first" && first.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "second" && second.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "third" && third.Contains(Winning))
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
