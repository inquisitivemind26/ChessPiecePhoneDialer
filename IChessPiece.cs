using System;
namespace ChessPhoneDialer
{
	public interface IChessPiece
	{
		List<Position> GetAllMoves(int row, int col, IKeyPadLayout keyPad);
	}
}

