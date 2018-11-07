using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Split
    {
        public void Twos()
        {
            Table.DrawTable();
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on any two numbers you want to split.");
            Console.WriteLine("A  split consists of 2 numbers that touch, 1/2, 2/3, 3/6, etc.");
            Console.WriteLine("Please enter the 2 numbers you want to bet on one at a time.");
            Console.WriteLine("You choose to split, first number: ");
            int bet1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("You choose to split, second number: ");
            int bet2 = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("---------------------------------------------------------------");

            if (Winning == bet1 || Winning == bet2)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose split: {bet1}, {bet2}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else
            {
                Console.WriteLine($"You chose split: {bet1}, {bet2}");
                Console.WriteLine($"The winning number was: {Winning}");
                Console.WriteLine("You lose this round, better luck next time.");
            }
        }
    }
}
