using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class FindTheParityOutlierTests
{

    [Theory]
    [InlineData(new int[] { 2, 6, 8, -10, 3 }, 3)]
    [InlineData(new int[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 }, 206847684)]
    [InlineData(new int[] { 0, 1 }, 0)]
    [InlineData(new int[] { -5, 6, 6 }, -5)]
    public void FindTheParityOutlier_ShouldReturnExpected(int[] input, int expected)
    {
        FindTheParityOutlier.Solution(input).Should().Be(expected);
    }
}
