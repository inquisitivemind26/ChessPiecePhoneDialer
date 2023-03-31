using System;
using System.Collections.Generic;

namespace ChessPhoneDialer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number for the Chess Piece");
            Console.WriteLine("1:Rook");
            Console.WriteLine("2:Pawn");
            Console.WriteLine("3:Knight");
            Console.WriteLine("4:Bishop");
            
            Console.WriteLine("Press Q to Quit!");

            var input = Console.ReadLine();

            while (input?.ToLower() != "q")
            {
                int phoneNumbersCount = -1;

                switch (Convert.ToInt32(input))
                {
                    case 1:
                        var keyPad = new KeyPad(new StandardPhoneKeyPad(), new StandardPhoneNumberValidator());
                        phoneNumbersCount = keyPad.GetPhoneNumbersCount(new Rook());
                        break;
                    case 2:
                        Console.WriteLine("Needs Pawn implementation");
                        break;
                    case 3:
                        Console.WriteLine("Needs Knight implementation");
                        break;
                    case 4:
                        Console.WriteLine("Needs Bishop implementation");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry!");
                        break;
                }

                if(phoneNumbersCount > -1)
                    Console.WriteLine($"Total Phone Numbers: {phoneNumbersCount}");

                input = Console.ReadLine();
            }
        }
    }
}