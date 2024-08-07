using AlbinRonnkvist.Kata.Solutions.FiveKyu;

namespace AlbinRonnkvist.Kata.Tests.FiveKyu;

public class SimplePigLatinTests
{
    [Theory]
    [InlineData("Pig latin is cool", "igPay atinlay siay oolcay")]
    [InlineData("This is my string", "hisTay siay ymay tringsay")]
    [InlineData("Hello world !", "elloHay orldway !")]
    public void KataTests(string sentence, string expected)
    {
        SimplePigLatin.Solution(sentence).Should().Be(expected);
    }
}
