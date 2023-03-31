﻿using System;
namespace ChessPhoneDialer
{
	public class Position
	{
		public int Row { get; set; }
        public int Column { get; set; }

		public Position(int row, int col)
		{
			Row = row;
			Column = col;
		}
	}
}

