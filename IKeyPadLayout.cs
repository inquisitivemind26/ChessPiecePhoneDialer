using System;
namespace ChessPhoneDialer
{
	public interface IKeyPadLayout
	{
        char[,] keys { get; set; }
    }
}

