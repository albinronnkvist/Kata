using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class StopSpinningMyWordsTests
{
    [Theory]
    [InlineData(null, "")]
    [InlineData("", "")]
    [InlineData("    ", "")]
    [InlineData("tEst", "tEst")]
    [InlineData("Welcome", "emocleW")]
    [InlineData("Hey fellow Warriors", "Hey wollef sroirraW")]
    [InlineData("This sentence is a sentence", "This ecnetnes is a ecnetnes")]
    public static void StopSpinningMyWords_WordsWithFiveOrMoreLettersShouldBeReversed(string sentence, string expected)
    {
        StopSpinningMyWords.Solution(sentence).Should().Be(expected);
    }
}
