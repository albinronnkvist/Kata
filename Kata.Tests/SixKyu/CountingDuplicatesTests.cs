using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class CountingDuplicatesTests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("abcde", 0)]
    [InlineData("aabbcde", 2)]
    [InlineData("aabBcde", 2)]
    [InlineData("Indivisibility", 1)]
    [InlineData("Indivisibilities", 2)]
    public void KataTests(string word, int expected)
    {
        CountingDuplicates.Solution(word).Should().Be(expected);
    }
}
