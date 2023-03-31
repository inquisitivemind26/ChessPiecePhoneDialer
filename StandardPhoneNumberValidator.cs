using System;
namespace ChessPhoneDialer
{
	public class StandardPhoneNumberValidator : IPhoneNumberValidator
	{
		public bool IsValid(string phoneNumber)
        {

            if (phoneNumber.Length != 7
                || (phoneNumber[0] == '0' || phoneNumber[0] == '1')
                || (phoneNumber.Contains("*") || phoneNumber.Contains("#"))
                )
            {
                return false;
            }
                        
            return true;
        }
    }
}

