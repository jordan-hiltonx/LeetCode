// https://leetcode.com/problems/letter-combinations-of-a-phone-number/

using System.Diagnostics;

var dict = new Dictionary<string, string>();
dict.Add("a", "2");
dict.Add("b", "2");
dict.Add("c", "2");
dict.Add("d", "3");
dict.Add("e", "3");
dict.Add("f", "3");
dict.Add("g", "4");
dict.Add("h", "4");
dict.Add("i", "4");
dict.Add("j", "5");
dict.Add("k", "5");
dict.Add("l", "5");
dict.Add("m", "6");
dict.Add("n", "6");
dict.Add("o", "6");
dict.Add("p", "7");
dict.Add("q", "7");
dict.Add("r", "7");
dict.Add("s", "7");
dict.Add("t", "8");
dict.Add("u", "8");
dict.Add("v", "8");
dict.Add("w", "9");
dict.Add("x", "9");
dict.Add("y", "9");
dict.Add("z", "9");
var possibleLetters = new Dictionary<string, string>();
var sw = new Stopwatch();
IList<string> LetterCombinations(string digits)
{
    sw.Start();
    var digitArray = digits.ToCharArray();
    foreach (var letter in digitArray)
    {
        foreach (var dictVal in dict)
        {
            if (dictVal.Value == letter.ToString())
            {
                possibleLetters.Add(dictVal.Key, dictVal.Value);
            }
        }
    }
    
    foreach (var letter in possibleLetters)
    {
        var x = letter.Value;
        
    }

    foreach (var r in possibleLetters)
    {
        Console.WriteLine(r);
    }
    
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds); 
    return new List<string>();
}

LetterCombinations("23");
