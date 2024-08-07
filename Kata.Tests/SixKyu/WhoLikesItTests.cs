using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class WhoLikesItTests
{
      
    [Fact]
    public void ZeroNameTest()
    {
        WhoLikesIt.Solution(new string[0]).Should().Be("no one likes this");
    }
    
    [Fact]
    public void OneNameTest()
    {
        var names = new string[] { "Peter" };
        WhoLikesIt.Solution(names).Should().Be("Peter likes this");
    }
    
    [Fact]
    public void TwoNamesTest()
    {
        var names = new string[] { "Peter", "Paul" };
        WhoLikesIt.Solution(names).Should().Be("Peter and Paul like this");
    }

    [Fact]
    public void ThreeNamesTest()
    {
        var names = new string[] { "Peter", "Paul", "George" };
        WhoLikesIt.Solution(names).Should().Be("Peter, Paul and George like this");
    }

    [Theory]
    [InlineData(new string[] { "Peter", "Paul", "George", "Mark" }, "Peter, Paul and 2 others like this")]
    [InlineData(new string[] { "Bryan", "Paul", "George", "Mark", "John" }, "Bryan, Paul and 3 others like this")]
    [InlineData(new string[] { "Peter", "Craig", "George", "Mark", "John", "Alex" }, "Peter, Craig and 4 others like this")]
    public void FourOrMoreNamesTest(string [] names, string expected)
    {
        WhoLikesIt.Solution(names).Should().Be(expected);
    }
}
