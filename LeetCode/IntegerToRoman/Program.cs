using System.Text;

///summary
/// Given an integer, convert it to a Roman numeral.
///summary

Console.WriteLine("Pick a number: ");
var str = Console.ReadLine();
var num = int.Parse(str);

int[] values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
string[] symbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];

var result = new StringBuilder();

for (int i = 0; i < values.Length; i++) // looping through value array
{
    while (num >= values[i]) // while given num is greater or equal to the i value 
    {
        num -= values[i]; // subtract given num from value i
        result.Append(symbols[i]); // add symbol of corresponding i in symbol []
    }
}

Console.WriteLine(result.ToString());

