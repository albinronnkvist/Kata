using System.Text.RegularExpressions;

namespace AlbinRonnkvist.Kata.Solutions.FiveKyu;

/*
In this kata you have to create a domain name validator mostly compliant with RFC 1035, RFC 1123, and RFC 2181

For purposes of this kata, following rules apply:

    Domain name may contain subdomains (levels), hierarchically separated by . (period) character
    Domain name must not contain more than 127 levels, including top level (TLD)
    Domain name must not be longer than 253 characters (RFC specifies 255, but 2 characters are reserved for trailing dot and null character for root level)
    Level names must be composed out of lowercase and uppercase ASCII letters, digits and - (minus sign) character
    Level names must not start or end with - (minus sign) character
    Level names must not be longer than 63 characters
    Top level (TLD) must not be fully numerical

Additionally, in this kata

    Domain name must contain at least one subdomain (level) apart from TLD
    Top level validation must be naive - ie. TLDs nonexistent in IANA register are still considered valid as long as they adhere to the rules given above.

The validation function accepts string with the full domain name and returns boolean value indicating whether the domain name is valid or not.

Examples:
validate('codewars') == False
validate('g.co') == True
validate('codewars.com') == True
validate('CODEWARS.COM') == True
validate('sub.codewars.com') == True
validate('codewars.com-') == False
validate('.codewars.com') == False
validate('example@codewars.com') == False
validate('127.0.0.1') == False
*/

public static class DomainNameValidator
{
    public static bool Solution(string domain)
    {
        if (domain.Length > 253
            || domain.Count(c => c == '.') < 1)
        {
            return false;
        }

        var levels = domain.Split('.');
        if (levels.Length > 127
            || levels.Any(level => level.Length > 63
            || level.StartsWith("-")
            || level.EndsWith("-")))
        {
            return false;
        }

        if (int.TryParse(levels.Last(), out _))
        {
            return false;
        }

        var regex = new Regex(@"^[a-zA-Z0-9\-]+$"); // lowercase and uppercase ASCII letters, digits, and minus signs
        return levels.All(level => regex.IsMatch(level));
    }
}
