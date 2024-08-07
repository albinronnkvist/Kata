using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class TakeATenMinutesWalkTests
{
    private static Random rnd = new Random();
  
    private static string[][] pass = new string[][]
    {
        new string[] {"n","s","n","s","n","s","n","s","n","s"},
        new string[] {"e","w","e","w","n","s","n","s","e","w"},
        new string[] {"n","s","e","w","n","s","e","w","n","s"}
    };
    
    private static string[][] fail = new string[][]
    {
        new string[] {"n"},
        new string[] {"n","s"},
        new string[] {"n","s","n","s","n","s","n","s","n","s","n","s"},
        new string[] {"n","s","e","w","n","s","e","w","n","s","e","w","n","s","e","w"},
        new string[] {"n","s","n","s","n","s","n","s","n","n"},
        new string[] {"e","e","e","w","n","s","n","s","e","w"},
        new string[] {"n","n","n","n","n","e","e","e","e","e"},
        new string[] {"s","s","s","s","s","w","w","w","w","w"},
        new string[] {"n","n","n","n","n","w","w","w","w","w"},
        new string[] {"s","s","s","s","s","e","e","e","e","e"},
        new string[] {"n","s","e","w","n","s","e","w","n","s","e","w","n","s","e","w","n","s","e","w"},
    };
    
    private static object[] testCases = new object[]
    {
        new object[] {fail[0], false, "should return false if walk is too short"},
        new object[] {fail[1], false, "should return false if walk is too short"},
        new object[] {fail[2], false, "should return false if walk is too long"},
        new object[] {fail[3], false, "should return false if walk is too long"},
        new object[] {fail[10], false, "should return false if walk is too long"},
        new object[] {fail[4], false, "should return false if walk does not bring you back to start"},
        new object[] {fail[5], false, "should return false if walk does not bring you back to start"},
        new object[] {fail[6], false, "should return false if walk does not bring you back to start"},
        new object[] {fail[7], false, "should return false if walk does not bring you back to start"},
        new object[] {fail[8], false, "should return false if walk does not bring you back to start"},
        new object[] {fail[9], false, "should return false if walk does not bring you back to start"},
        new object[] {pass[0], true, "should return true for a valid walk"},
        new object[] {pass[1], true, "should return true for a valid walk"},
        new object[] {pass[2], true, "should return true for a valid walk"},
    }.OrderBy(_ => rnd.Next()).ToArray();
  
    public static IEnumerable<object[]> TestCasesSource()
    {
        foreach (object[] testCase in testCases)
        {
            yield return new object[] { testCase[0], testCase[1], testCase[2] };
        }
    }
  
    [Theory]
    [MemberData(nameof(TestCasesSource))]
    public void TakeATenMinutesWalk_ShouldValidateWalk(string[] input, bool expected, string description)
    {
        TakeATenMinutesWalk.Solution(input).Should().Be(expected, description);
    }
}
