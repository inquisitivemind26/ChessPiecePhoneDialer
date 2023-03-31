using System;
namespace ChessPhoneDialer
{
	public class KeyPad
	{
        IKeyPadLayout KeyPadLayout { get; set; }
        IPhoneNumberValidator PhoneNumberValidator { get; set; }

        public KeyPad(IKeyPadLayout keyPadLayout, IPhoneNumberValidator phoneNumberValidator)
		{
			KeyPadLayout = keyPadLayout;
			PhoneNumberValidator = phoneNumberValidator;
		}

		internal int GetPhoneNumbersCount(IChessPiece piece)
		{
            // Count the number of valid phone numbers
            // Start from every position on the keypad
            int count = 0;
            for (int i = 0; i < KeyPadLayout.keys.GetLength(0); i++)
            {
                for (int j = 0; j < KeyPadLayout.keys.GetLength(1); j++)
                {
                    // Recursively build phone numbers
                    string firstDigit = KeyPadLayout.keys[i, j].ToString();
                    count += CountPhoneNumbers(i, j, firstDigit,piece);
                }
            }

            return count;

        }

        int CountPhoneNumbers(int row, int col, string currentNumber, IChessPiece piece)
        {
            // Base case
            if (currentNumber.Length == 7)
            {
               return PhoneNumberValidator.IsValid(currentNumber) ? 1 : 0;
            }

            // Recursive case: add next digit to phone number
          
            List<Position> moves = piece.GetAllMoves(row, col,KeyPadLayout);
            int count = 0;
            foreach (Position move in moves)
            {
                int newRow = move.Row;
                int newCol = move.Column;
                string nextDigit = KeyPadLayout.keys[newRow, newCol].ToString();
                count += CountPhoneNumbers(newRow, newCol, currentNumber + nextDigit, piece);
            }
            return count;
        }

    }
}

