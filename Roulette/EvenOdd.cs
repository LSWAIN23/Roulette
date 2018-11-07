using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class EvenOdd
    {
        public void EvOd()
        {
            Table.DrawTable();
            int[] even = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
            int[] odd = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on even or odd numbers.        (even/odd)");
            Console.Write("You choose: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if(Bet == "even" && even.Contains(Winning))
            {  
                    Console.WriteLine("Winner Winner Chicken Dinner!");
                    Console.WriteLine($"Your choice: {Bet}");
                    Console.WriteLine($"The winning number was: {Winning}");
            }

            else if(Bet == "odd" && odd.Contains(Winning))
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
