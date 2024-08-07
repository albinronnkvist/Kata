using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class BitCountingTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(4, 1)]
    [InlineData(7, 3)]
    [InlineData(9, 2)]
    [InlineData(10, 2)]
    [InlineData(26, 3)]
    [InlineData(77231418, 14)]
    [InlineData(12525589, 11)]
    [InlineData(3811, 8)]
    [InlineData(392902058, 17)]
    [InlineData(1044, 3)]
    [InlineData(10030245, 10)]
    public void BitCounting_ShouldReturnExpectedCountOfOnesInBits(int number, int expected)
    {
        BitCounting.Solution(number).Should().Be(expected);
    }
}
