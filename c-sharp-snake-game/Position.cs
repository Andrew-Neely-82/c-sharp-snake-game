﻿

namespace c_sharp_snake_game
{
    public class Position
    {
        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row+ Col);
        }
    }
}
