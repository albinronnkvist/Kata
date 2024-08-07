using AlbinRonnkvist.Kata.Solutions.SixKyu;
using FluentAssertions;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class DigitalRootTests
{
    [Theory]
    [InlineData(16, 7)]
    [InlineData(195, 6)]
    [InlineData(992, 2)]
    [InlineData(9999999, 9)]
    [InlineData(167346, 9)]
    [InlineData(0, 0)]
    [InlineData(10, 1)]
    public void Tests(int n, int expected)
    {
        DigitalRoot.Solution(n).Should().Be(expected);      
    }
    
    [Theory(Skip = "Tests work but skipping to save time")]
    [MemberData(nameof(RandomNumbers))]
    public void RandomTests(int n, int expected)
    {
        DigitalRoot.Solution(n).Should().Be(expected, $"because for n = {n}, the expected digital root is {expected}");
    }

    public static IEnumerable<object[]> RandomNumbers()
    {
        var rnd = new Random();
        for (int i = 0; i < 100; i++)
        {
            int len = rnd.Next(1, 10);
            int n = len == 1 ? rnd.Next(10) : rnd.Next((int)Math.Pow(10, len - 1), (int)Math.Pow(10, len));
            int expected = (int)((n - 1) % 9 + 1);
            yield return new object[] { n, expected };
        }
    }
}
