namespace AlbinRonnkvist.Kata.Solutions.SixKyu;

public static class BinaryToTextConversion
{
    public static string Solution(string binary)
        => string.Concat(Enumerable.Range(0, binary.Length / 8)
            .Select(i => binary.Substring(i * 8, 8))
            .Select(byteString => (char)Convert.ToInt32(byteString, 2)));
}
