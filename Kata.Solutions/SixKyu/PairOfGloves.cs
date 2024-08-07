namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
Determine the number of pair of gloves you can constitute from the gloves you have in your drawer.

Given an array describing the color of each glove, return the number of pairs you can constitute, assuming that only gloves of the same color can form pairs.
*/

public static class PairOfGloves
{
    public static int Solution(string[] gloves) 
        => gloves.GroupBy(x => x)
            .Select(x => x.Count() / 2)
            .Sum();
}