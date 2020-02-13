using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Board
    {
        //member vars
        int boardSize = 20;
        //constructor
        public Board()
        {
            string[,] board = new string[boardSize, boardSize];
            
            
            Console.WriteLine("____1__2__3__4__5__6__7__8__9_10_11_12_13_14_15_16_17_18_19_20");
            for (int i = 0; i < boardSize; i++)
            {
                
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = "[0]";
                    
                }
                
            }
            
            int counter = 1;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (counter < 10)
                {
                    Console.Write("_"+counter+"_");
                }
                else
                {
                    Console.Write(counter + "_");
                }
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 5 && j == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(board[i, j]);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.Write(board[i, j]);
                    }
                }
                counter++;
                Console.WriteLine("");
            }
            
        }
        //member methods

    }
}
