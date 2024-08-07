namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
Given an array of integers, find the one that appears an odd number of times.
There will always be only one integer that appears an odd number of times.

Examples:
[7] should return 7, because it occurs 1 time (which is odd).
[0] should return 0, because it occurs 1 time (which is odd).
[1,1,2] should return 2, because it occurs 1 time (which is odd).
[0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
*/

public static class FindTheOddInt
{
    public static int Solution(int[] integers) 
    {
        if(integers.Length is 1) {
            return integers[0];
        }

        var integerOccurrences = new Dictionary<int, int>();
        foreach (var integer in integers)
        {
            if (integerOccurrences.TryGetValue(integer, out var occurences))
            {
                integerOccurrences[integer] = occurences + 1;
                continue;
            }
                    
            integerOccurrences.Add(integer, 1);
        }

        return integerOccurrences.First(x => x.Value % 2 != 0).Key;
    }
}
