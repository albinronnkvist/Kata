using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class RomanNumeralsDecoderTests
{
    [Theory]
	[InlineData(1, "I")]
	[InlineData(2, "II")]
	[InlineData(4, "IV")]
    [InlineData(21, "XXI")]
	[InlineData(500, "D")]
	[InlineData(1000, "M")]
	[InlineData(1954, "MCMLIV")]
	[InlineData(1990, "MCMXC")]
	[InlineData(2008, "MMVIII")]
	[InlineData(2014, "MMXIV")]
	public void RomanNumeralsDecoder_ShouldReturnExpectedNumber(int expected, string roman)
	{
		RomanNumeralsDecoder.Solution(roman).Should().Be(expected);
	}
}