namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples:
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 

*/

public static class DuplicateEncoder
{
    public static string Solution(string word)
    {
        var charCount = new Dictionary<char, int>();
        word = word.ToLower();
        foreach (var c in word)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        return word.Aggregate("", (currentResult, currentChar) =>
            currentResult + (charCount[currentChar] > 1 ? ")" : "("));
    }
}
