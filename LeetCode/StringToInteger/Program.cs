// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.
// The algorithm for myAtoi(string s) is as follows:
//    - Whitespace: Ignore any leading whitespace (" ").
//    - Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
//    - Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached.
//      If no digits were read, then the result is 0.
//    - Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range.
//      Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
// Return the integer as the final result.

using System.Globalization;
using System.Text;

var strNumbers = new StringBuilder();
var cont = true;
var num = 0;
//var answer = 0;

Console.WriteLine("Pick a number: ");
var str = Console.ReadLine();


foreach (char x in str)
{
    while (cont)
    {
        bool numbersOnly = int.TryParse(x.ToString(), out num);
        if (x.ToString() == "-" || x.ToString() == "+")
        {
            strNumbers.Append(x.ToString());
            break;
        }
        else if (numbersOnly && x.ToString() != "-" && x.ToString() != "+" && x.ToString() != " ")
        {
            strNumbers.Append(num.ToString());
            break;
        }
        else
        {
            if (x.ToString() == " ")
            {
                break;
            }
            cont = false;
        }
            
    }
}

long.TryParse(strNumbers.ToString(), out var answer);

if (answer >= int.MaxValue)
{
    answer = int.MaxValue;
}

if (answer <= int.MinValue)
{
    answer = int.MinValue;
}

Console.WriteLine((int)answer);
