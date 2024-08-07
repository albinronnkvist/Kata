using AlbinRonnkvist.Kata.Solutions.FiveKyu;

namespace AlbinRonnkvist.Kata.Tests.FiveKyu;

public class MovingZerosToTheEndTests
{
    [Theory]
    [InlineData(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}, new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0})]
    [InlineData(new int[] {0, 2, 0, 1, 0, 1, 0, 3, 0, 1}, new int[] {2, 1, 1, 3, 1, 0, 0, 0, 0, 0})]
    public void MovingZerosToTheEnd_ShouldReturnExpected(int [] input, int [] expected)
    {
        MovingZerosToTheEnd.Solution(input).Should().BeEquivalentTo(expected);
    }
}
