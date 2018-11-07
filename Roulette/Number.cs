using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Number
    {
        public void One()
        {
            Table.DrawTable();
            Random rand = new Random();
            int Winning = rand.Next(0, 37);
            int zero = Convert.ToInt32("00");

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose 0, 00, or any number from 1-36.");
            Console.Write("You choose: ");
            int Bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------");

            if (Winning == zero)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your number: {zero}");
                Console.WriteLine($"The winning number is {zero}.");
            }

            if (Bet == Winning)
           {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"Your number: {Bet}");
                Console.WriteLine($"The winning number is {Winning}.");                
           }
           else if (Bet != Winning)
           {
                Console.WriteLine($"Your number: {Bet}");
                Console.WriteLine($"The winning number is {Winning}.");
                Console.WriteLine("You lose this round, better luck next time.");
           }
            
        }
    }
}
