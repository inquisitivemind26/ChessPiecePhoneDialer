using System;
namespace ChessPhoneDialer
{
    public class Rook : IChessPiece
    {
        public List<Position> GetAllMoves(int rowIndex, int colIndex, IKeyPadLayout keypad)
        {
            // Rook moves any number of places horizontal (rows) and vertical (columns)
            List<Position> moves = new List<Position>();

            // Iterate through all rows
            for (int row = 0; row < keypad.keys.GetLength(0); row++)
            {
                //Do not count where currently the piece is
                if (row != rowIndex)
                {
                    moves.Add(new Position(row, colIndex));
                }
            }

            //Iterate through all columns
            for (int col = 0; col < keypad.keys.GetLength(1); col++)
            {
                // Do not count where currently the piece is
                if (col != colIndex)
                {
                    moves.Add(new Position(rowIndex, col));
                }
            }
            return moves;
        }
    }

}

