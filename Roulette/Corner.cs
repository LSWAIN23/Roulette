using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Corner
    {
        public void Fours()
        {
            Table.DrawTable();
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on any four numbers you want to corner.");
            Console.WriteLine("A corner consists of 4 numbers that touch, 1/2/4/5, 2/3/5/6, 13/14/16/17, etc.");
            Console.WriteLine("Please enter the 4 contiguous numbers you want to bet on one at a time.");
            Console.WriteLine("You choose to corner, first number: ");
            int bet1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("You choose to corner, second number: ");
            int bet2 = int.Parse(Console.ReadLine().Trim());
            Console.Write("You choose to corner, third number: ");
            int bet3 = int.Parse(Console.ReadLine().Trim());
            Console.Write("You choose to corner, fourth number: ");
            int bet4 = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("---------------------------------------------------------------");

            if (Winning == bet1 || Winning == bet2 || Winning == bet3 || Winning == bet4)
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose corner: {bet1}, {bet2}, {bet3}, {bet4}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else
            {
                Console.WriteLine($"You chose corner: {bet1}, {bet2}, {bet3}, {bet4}");
                Console.WriteLine($"The winning number was: {Winning}");
                Console.WriteLine("You lose this round, better luck next time.");
            }
        }
    }
}
