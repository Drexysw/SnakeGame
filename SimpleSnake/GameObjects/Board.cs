using System;
using System.Collections.Generic;

namespace SimpleSnake.GameObjects
{
    internal class Board
    {
        private const char wallSymbol = '\u25A0';
        private int rows;
        private int cols;
        public Board(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            DrawVerticals();
            DrawHorizontals();
        }


        private void DrawVerticals()
        {
            for (int col = 0; col < cols; col++)
            {
                Console.SetCursorPosition(col + 1, 0);
                Console.Write(wallSymbol);
            }

            for (int col = 0; col < cols; col++)
            {
                Console.SetCursorPosition(col + 1, 0);
                Console.Write(wallSymbol);
            }
        }
        private void DrawHorizontals()
        {
            for (int row = 0; row < rows; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.WriteLine(wallSymbol);
                Console.WriteLine();
            }

            for (int i = 0; i < UPPER; i++)
            {
                
            }
        }
    }
}
