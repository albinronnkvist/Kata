using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class BinaryToTextConversionTests
{
    [Theory]
    [InlineData("", "")]
    [InlineData("Hello", "0100100001100101011011000110110001101111")]
    [InlineData("1011", "00110001001100000011000100110001")]
    [InlineData("Sparks flew.. emotions ran high!", "0101001101110000011000010111001001101011011100110010000001100110011011000110010101110111001011100010111000100000011001010110110101101111011101000110100101101111011011100111001100100000011100100110000101101110001000000110100001101001011001110110100000100001")]
	public void Basic_Tests(string expected, string input)
	{
        BinaryToTextConversion.Solution(input).Should().Be(expected);
	}
}
