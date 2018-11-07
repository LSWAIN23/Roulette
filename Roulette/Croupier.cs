using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Croupier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Digital Roulette.");
            Console.WriteLine("If you don't know how to play start by making a selection below and rules will be explained as you go.");

            while(true)
            {
                Console.WriteLine("Please select a number in acordance to the type of bet you would like to place.");
                Console.WriteLine(@"
                1. Single Number
                2. Even or Odd Number
                3. Red or Black Numbers
                4. Low or High Numbers
                5. Groups of 12 Numbers
                6. Column of Numbers
                7. Street of Numbers
                8. Groups of 6 Numbers
                9. Split, any 2 contiguous Numbers
                10. Corner, any intersection of 4 contiguous Numbers"@);

                int type = Convert.ToInt32(Console.ReadLine());

                if (type == 1)
                {
                    Number num = new Number();
                    num.One();
                }
                else if (type == 2)
                {
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvOd();
                }
                else if (type == 3)
                {
                    RedBlack redBlack = new RedBlack();
                    redBlack.Color();
                }
                else if (type == 4)
                {
                    LowHigh lowHigh = new LowHigh();
                    lowHigh.loHi();
                }
                else if (type == 5)
                {
                    Dozens dozens = new Dozens();
                    dozens.Doz();
                }
                else if (type == 6)
                {
                    Columns columns = new Columns();
                    columns.Col();
                }
                else if (type == 7)
                {
                    Street street = new Street();
                    street.St();
                }
                else if (type == 8)
                {
                    HalfDozen halfDozen = new HalfDozen();
                    halfDozen.Half();
                }
                else if (type == 9)
                {
                    Split split = new Split();
                    split.Twos();
                }
                else if (type == 10)
                {
                    Corner corner = new Corner();
                    corner.Fours();
                }

                Console.WriteLine("Would you like to make another bet?         (y/n)");
                string replay = Console.ReadLine();

                if(replay == "n")
                {
                    Console.WriteLine("Thank you for playing.");
                    break;
                }

                Console.Clear();
            }
        }
    }
}
