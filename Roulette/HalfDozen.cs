using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class HalfDozen
    {
        public void Half()
        {
            Table.DrawTable();
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on any one of the eleven doubles.");
            Console.WriteLine("A double consists of 6 consecutive numbers, 1/2/3/4/5/6, 12/13/14/15/16/17 etc.");
            Console.WriteLine("Choose a set of double.            (one/two/three/four.../eleven)");
            Console.Write("You choose double: ");
            string Bet = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "one" && (Winning >= 1 && Winning <= 6))
            {                               
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");                
            }

            else if (Bet == "two" && (Winning >= 4 && Winning <= 9))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "three" && (Winning >= 7 && Winning <= 12))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "four" && (Winning >= 10 && Winning <= 15))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "five" && (Winning >= 13 && Winning <= 18))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "six" && (Winning >= 16 && Winning <= 21))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "seven" && (Winning >= 19 && Winning <= 24))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "eight" && (Winning >= 22 && Winning <= 27))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "nine" && (Winning >= 25 && Winning <= 30))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "ten" && (Winning >= 28 && Winning <= 33))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "eleven" && (Winning >= 31 && Winning <= 36))
            {
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else
            {
                Console.WriteLine($"You choose double: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
                Console.WriteLine("You lose this round, better luck next time.");
            }
        }
    }
}
