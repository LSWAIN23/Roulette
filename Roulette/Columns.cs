using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Columns
    {
        public void Col()
        {
            Table.DrawTable();
            int[] one = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] two = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] three = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on colums one (1-34), two (2-35), or three (3-36)");       
            Console.WriteLine("The values in each column increase by 3 from the starting number.              (one/two/three)");
            Console.Write("You choose column: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "one" && one.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "two" && two.Contains(Winning))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your choice: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "three" && three.Contains(Winning))
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
