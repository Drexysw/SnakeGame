using System;

namespace SimpleSnake.GameObjects
{
    internal class Point
    {
        protected int CurrentRow { get; set; }
        protected int CurrentCol { get; set; }

        public Point(int row, int col)
        {
            this.CurrentRow = row;
            this.CurrentCol = col;
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.CurrentCol, this.CurrentRow);
            Console.Write(symbol);
        }
        public void Draw(int row, int col, char symbol)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
    }
}
