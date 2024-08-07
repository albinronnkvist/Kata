namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

/*
Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. 
You can guarantee that input is non-negative.

Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case
*/

public static class BitCounting
{
    public static int Solution(int number)
    {
        var binary = Convert.ToString(number, 2);
        
        var count = 0;
        foreach(var character in binary) {
            if(character is '1') {
                count++;
            }
        }
        
        return count;
    }
}
