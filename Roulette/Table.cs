using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public static class Table
    {
        public static int Rows { get; set; }
        public static int Columns { get; set; }

        public static void DrawTable()
        {
            Rows = 12;
            Columns = 3;
            int start = 3;
            int boardNum = 0;
            for(int i = 0; i < Columns; ++i)
            {
                boardNum = start;
                for(int j = 0; j < Rows; ++j)
                {
                    Console.Write(boardNum + " | ");
                    boardNum += 3;
                }

                Console.WriteLine();
                start--;
            }

        }
    }  
}
