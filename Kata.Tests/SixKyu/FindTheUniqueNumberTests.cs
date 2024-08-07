using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class FindTheUniqueNumberTests
{
    [Theory]
    [InlineData(new [] {0, 0, 1, 0}, 1)]
    [InlineData(new [] {1, 2, 2, 2}, 1)]
    [InlineData(new [] {-2, 2, 2, 2}, -2)]
    [InlineData(new [] {-3, -3, 0, -3}, 0)]
    [InlineData(new [] {11, 11, 14, 11, 11}, 14)]
    [InlineData(new [] {8, 8, 8, 8, 7}, 7)]
    public void BaseTest(IEnumerable<int> numbers, int expected)
    {
        FindTheUniqueNumber.Solution(numbers).Should().Be(expected);
    }
    
    [Fact]
    public void RandomTest()
    {
      for (var i = 10000; i < 10020; i++)
      {
        var arr = Gen(i);
        FindTheUniqueNumber.Solution(arr).Should().Be(InnerSolution(arr));
      }
    }
    
    private IEnumerable<int> Gen(int max)
    {
      var number = new Random().Next(max);
      var count = new Random().Next(3, 20);
      var unique = new Random().Next(max);
      
      while (unique == number)
      {
        unique = new Random().Next(max);
      }
      
      var list = new List<int>();
      for (var i = 0; i < count; i++)
      {
        list.Add(number);
      }
      
      list[new Random().Next(count - 1)] = unique;
      
      return list;
    }
    
    private int InnerSolution(IEnumerable<int> numbers)
    {
      var tmp = numbers.OrderBy(n => n).ToList();
      return tmp[0] == tmp[1] ? tmp[tmp.Count - 1] : tmp[0];
    }
}
