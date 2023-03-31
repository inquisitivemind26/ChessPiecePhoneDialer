# ChessPiecePhoneDialer
Problem:
The following diagram is of a standard telephone keypad. It consists of a 4x3 grid of
buttons. Using the valid moves of a piece from the game of chess, varying combinations
of 7-digit phone numbers can be derived. For example, starting in the upper-right corner
(the “3” key) using a rook (which moves any number of spaces horizontally or
vertically), one valid number is: 314-5289.
1 2 3
4 5 6
7 8 9
* 0 #
Write a program that will count the number of valid 7-digit phone numbers that can be
traced out on the keypad for a given chess piece. The following rules define a valid phone
number:
• Seven digits in length
• Cannot start with a 0 or 1
• Cannot contain a * or #
