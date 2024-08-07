using AlbinRonnkvist.Kata.Solutions.SixKyu;

namespace AlbinRonnkvist.Kata.Tests.SixKyu;

public class PairOfGlovesTests
{

    [Fact]
    public void SampleTests()
    {
      CustomAssertion(0, new string[] {"Green", "Blue", "Purple", "Gray"});
      CustomAssertion(0, new string[] {});
      CustomAssertion(0, new string[] {"Purple"});
      
      CustomAssertion(1, new string[] {"Blue", "Purple", "Blue", "Gray", "Lime", "Black"});
      CustomAssertion(1, new string[] {"Blue", "Aqua", "Blue", "Teal", "Blue", "Black"});
      
      CustomAssertion(2, new string[] {"Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua"});
    }
    
    [Fact]
    public static void RandomTests() {
      Random rand = new Random();
      int Solution(string[] gloves) {
        int count = 0;
        List<string> pairs = new List<string>();

        foreach (string glove in gloves) {
          if (pairs.Contains(glove)) {
            pairs.Remove(glove);
            count++;
          }

          else {
            pairs.Add(glove);
          }
        }

        return count;
      }
      string[] RandArray(int length) { 
        return Enumerable.Range(0, length)
                         .Select(x => Colors[rand.Next(0, Colors.Length)])
                         .ToArray(); 
      }
      
      string[] array;
      int expected;
      
      for (int i = 0; i < 75; i++) {
        array = RandArray(rand.Next(0, 50));
        expected = Solution(array);
        
        CustomAssertion(expected, array);
      }
    }
    
    private static string[] Colors = new string[] {
      "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "Purple", "Gray", "Lime",
      "Black", "Aqua", "Teal", "Brown", "Orange", "Olive", "Pink"
    };

    private static void CustomAssertion(int expected, string[] input)
    {
        PairOfGloves.Solution(input)
            .Should().Be(expected, $"because the input was [{string.Join(", ", input)}]");
    }

}