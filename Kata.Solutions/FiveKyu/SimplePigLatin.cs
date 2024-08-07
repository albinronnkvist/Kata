namespace AlbinRonnkvist.Kata.Solutions.FiveKyu;

/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples:
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/

public static class SimplePigLatin
{
    public static string Solution(string sentence)
    {
        var words = sentence.Split(' ');
        var pigLatinWords = words.Select(word => IsPunctuation(word) 
            ? word 
            : word.Substring(1) + word[0] + "ay");

        return string.Join(" ", pigLatinWords);
    }

    private static bool IsPunctuation(string s) 
        => s.All(c => char.IsPunctuation(c));
}
