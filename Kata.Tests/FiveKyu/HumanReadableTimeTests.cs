using AlbinRonnkvist.Kata.Solutions.FiveKyu;

namespace AlbinRonnkvist.Kata.Tests.FiveKyu;

public class HumanReadableTimeTests
{
    [Theory]
    [InlineData(0, "00:00:00")]
    [InlineData(59, "00:00:59")]
    [InlineData(60, "00:01:00")]
    [InlineData(90, "00:01:30")]
    [InlineData(3599, "00:59:59")]
    [InlineData(3600, "01:00:00")]
    [InlineData(45296, "12:34:56")]
    [InlineData(86399, "23:59:59")]
    [InlineData(86400, "24:00:00")]
    [InlineData(359999, "99:59:59")]
    public void FixedTests(int seconds, string expected)
    {
        HumanReadableTime.Solution(seconds).Should().Be(expected);
    }
}
