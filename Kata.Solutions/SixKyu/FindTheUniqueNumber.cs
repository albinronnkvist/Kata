namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55

It’s guaranteed that array contains at least 3 numbers.
The tests contain some very huge arrays, so think about performance.
*/

public static class FindTheUniqueNumber
{
    public static int Solution(IEnumerable<int> numbers)
        => numbers.GroupBy(x => x)
            .Single(x => x.Count() is 1).Key;
}
