using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class DuplicateEncoderTests
{
    [Theory]
    [InlineData("din", "(((")]
    [InlineData("recede", "()()()")]
    [InlineData("Success", ")())())")]
    [InlineData("(( @", "))((")]
    [InlineData("CodeWarrior", "()(((())())")]
    [InlineData("Supralapsarian", ")()))()))))()(")]
    [InlineData("iiiiii", "))))))")]
    public void BasicTests(string input, string expected)
    {
        DuplicateEncoder.Solution(input).Should().Be(expected);
    }
    
    [Theory]
    [InlineData("(( @", "))((")]
    [InlineData(" ( ( )", ")))))(")]
    public void ParenthesesTests(string input, string expected)
    {
        DuplicateEncoder.Solution(input).Should().Be(expected);
    }
}
