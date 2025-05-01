// https://leetcode.com/problems/reverse-integer/description/

using System.Diagnostics;

var sw = new Stopwatch();
var result = "";
int Reverse(int x)
{
    sw.Start();
    var y = x.ToString().ToCharArray();
    string negative = null;
    if (x >= Int32.MaxValue || x <= Int32.MinValue)
    {
        x = 0;
    }
    if (y[0].ToString() == "-")
    {
        var absolute = Math.Abs(x);
        var reverseNeg = string.Join("", absolute.ToString().Reverse());
        var parseNeg = Int32.TryParse(reverseNeg, out var parsedNeg);
        result = parseNeg ? $"-{parsedNeg}" : "0";
    }
    else
    {
        var reverse = string.Join("", x.ToString().Reverse());
        var parse = Int32.TryParse(reverse, out var parsed);
        result = parse ? $"{parsed}" : "0";
    }
    
    sw.Stop();
    return int.Parse(result);
}

Console.WriteLine(Reverse(-1563847412));
Console.WriteLine(sw.ElapsedMilliseconds);
