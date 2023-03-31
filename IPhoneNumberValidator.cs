using System;
namespace ChessPhoneDialer
{
	public interface IPhoneNumberValidator
	{
		bool IsValid(string phoneNumber);
	}
}

