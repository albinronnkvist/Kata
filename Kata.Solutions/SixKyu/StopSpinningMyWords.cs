namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed.
Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples:
"Hey fellow warriors"  --> "Hey wollef sroirraw" 
"This is a test        --> "This is a test" 
"This is another test" --> "This is rehtona test"
*/

public static class StopSpinningMyWords
{
    public static string Solution(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
        {
            return string.Empty;
        }

        var words = sentence.Split(' ');
        if (words.Length <= 1)
        {
            return HandleSingleWordSentence(words);
        }

        return HandleMultiWordSentence(words);
    }

    private static string HandleSingleWordSentence(string[] words)
    {
        var singleWord = words[0];
        if (singleWord.Length < 5)
        {
            return singleWord;
        }

        var reversedWord = string.Empty;
        for (var i = singleWord.Length - 1; i >= 0; i--)
        {
            reversedWord += singleWord[i];
        }

        return reversedWord;
    }

    private static string HandleMultiWordSentence(string[] words)
    {
        var newSentence = string.Empty;
        foreach (var word in words)
        {
            if (word.Length >= 5)
            {
                var reversedWord = string.Empty;
                for (var i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                newSentence += reversedWord + " ";
                continue;
            }

            newSentence += word + " ";
        }

        return newSentence.Trim();
    }
}