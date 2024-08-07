using AlbinRonnkvist.Kata.Solutions.SixKyu;
using FluentAssertions;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class FindTheOddIntTests
{
    [Theory]
    [InlineData(5, new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 })]
    [InlineData(-1, new[] { 1,1,2,-2,5,2,4,4,-1,-2,5 })]
    [InlineData(5, new[] { 20,1,1,2,2,3,3,5,5,4,20,4,5 })]
    [InlineData(10, new[] { 10 })]
    [InlineData(10, new[] { 1,1,1,1,1,1,10,1,1,1,1 })]
    [InlineData(1, new[] { 5,4,3,2,1,5,4,3,2,10,10 })]
    public void FindTheOddInt_ShouldReturnOneIntegerThatAppearsOddNumberOfTimes(int expected, int[] integers)
    {
        FindTheOddInt.Solution(integers).Should().Be(expected);
    }
}
