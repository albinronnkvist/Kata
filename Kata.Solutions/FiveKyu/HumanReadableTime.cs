namespace AlbinRonnkvist.Kata.Solutions.FiveKyu;

/*
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

    HH = hours, padded to 2 digits, range: 00 - 99
    MM = minutes, padded to 2 digits, range: 00 - 59
    SS = seconds, padded to 2 digits, range: 00 - 59

The maximum time never exceeds 359999 (99:59:59)
*/

public static class HumanReadableTime
{
    public static string Solution(int seconds)
    {
        var hours = 0;
        var minutes = 0;
        
        while(seconds >= 3600)
        {
            hours++;
            seconds -= 3600;
        }
        
        while(seconds >= 60)
        {
            minutes++;
            seconds -= 60;
        }

        return $"{FormatTime(hours)}:{FormatTime(minutes)}:{FormatTime(seconds)}";
    }

    private static string FormatTime(int time)
    {
        return time < 10 ? $"0{time}" : time.ToString();
    }
}
