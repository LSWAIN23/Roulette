using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Street
    {
        public void St()
        {
            Table.DrawTable();
            Random rand1 = new Random();
            int Winning = rand1.Next(1, 36);

            Console.WriteLine("Time to place your bet.");
            Console.WriteLine("Please choose to bet on any one of the twelve rows.");
            Console.WriteLine("A row consists of 3 consecutive numbers, 1/2/3, 7/8/9 etc.              (one/two/three/four.../twelve)");
            Console.Write("You choose row: ");
            string Bet = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("---------------------------------------------------------------");

            if (Bet == "one")
            {
                if(Winning >= 1 && Winning <= 3)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "two")
            {
                if (Winning >= 4 && Winning >= 6)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "three")
            {
                if (Winning >= 7 && Winning <= 9)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "four")
            {
                if (Winning >= 10 && Winning <= 12)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

           else if (Bet == "five")
           {
                if (Winning >= 13 && Winning <= 15)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
           }

            else if (Bet == "six")
            {
                if (Winning >= 16 && Winning <= 18)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "seven")
            {
                if (Winning >= 19 && Winning <= 21)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "eight")
            {
                if (Winning >= 22 && Winning <= 24)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "nine")
            {
                if (Winning >= 25 && Winning <= 27)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "ten")
            {
                if (Winning >= 28 && Winning <= 30)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "eleven")
            {
                if (Winning >= 31 && Winning <= 33)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else if (Bet == "twelve")
            {
                if (Winning >= 34 && Winning <= 36)
                Console.WriteLine("Winner Winner Chicken Dinner!");
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
            }

            else
            {
                Console.WriteLine($"You chose row: {Bet}");
                Console.WriteLine($"The winning number was: {Winning}");
                Console.WriteLine("You lose this round, better luck next time.");
            }
        }
    }
}
