﻿using ChessConsole.BoardLayer;
using ChessConsole.BoardLayer.Enums;

namespace ChessConsole.ChessGameLayer
{
    class King : Piece
    {
        public King(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
