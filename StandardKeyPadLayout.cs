using System;
namespace ChessPhoneDialer
{
    public class StandardPhoneKeyPad : IKeyPadLayout
    {
        public char[,] keys { get; set; } = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' },
                { '*', '0', '#' }
        };

    }
}

