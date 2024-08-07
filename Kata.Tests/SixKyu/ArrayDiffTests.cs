using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class ArrayDiffTests
{
    [Theory]
    [InlineData(new int[] {1, 2}, new int[] {1}, new int[] {2})]
    [InlineData(new int[] {1, 2, 2}, new int[] {1}, new int[] {2, 2})]
    [InlineData(new int[] {1, 2, 2}, new int[] {2}, new int[] {1})]
    [InlineData(new int[] {1, 2, 2}, new int[] {}, new int[] {1, 2, 2})]
    [InlineData(new int[] {}, new int[] {1, 2}, new int[] {})]
    [InlineData(new int[] {1, 2, 3}, new int[] {1, 2}, new int[] {3})]
    public void ArrayDiff_ShouldReturnExpectedDiff(int[] a, int[] b, int[] expected)
    {
        ArrayDiff.Solution(a, b).Should().BeEquivalentTo(expected);
    }
}
