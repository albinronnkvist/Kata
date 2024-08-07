namespace AlbinRonnkvist.Kata.Solutions.FiveKyu;

/*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/

public static class MovingZerosToTheEnd
{
    public static int[] Solution(int[] arr) 
        => arr.OrderBy(x => x is 0).ToArray();
}
