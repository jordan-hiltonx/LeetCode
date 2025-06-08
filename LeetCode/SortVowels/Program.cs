// https://leetcode.com/problems/sort-vowels-in-a-string/description/

using System.Text;

string SortVowels(string s)
{
    // Define vowels set
    var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
    // Extract all vowels from the string
    var vowelChars = new List<char>();
    foreach (char c in s)
    {
        if (vowels.Contains(c))
        {
            vowelChars.Add(c);
        }
    }
        
    // Sort vowels by ASCII value
    vowelChars.Sort();
        
    // Build result string
    StringBuilder result = new StringBuilder();
    int vowelIndex = 0;
        
    foreach (char c in s)
    {
        if (vowels.Contains(c))
        {
            // Replace with next sorted vowel
            result.Append(vowelChars[vowelIndex]);
            vowelIndex++;
        }
        else
        {
            // Keep consonant in original position
            result.Append(c);
        }
    }
        
    return result.ToString();
}

Console.WriteLine(SortVowels(("lEetcOde")));