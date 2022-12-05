namespace AdventOfCode2022;

public static class StringExtensions
{
    public static string[] SplitToLines(this string input, string splitString = "\r\n")
    {
        return input.Replace(splitString, "|")
            .Split("|".ToCharArray(), StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    }
}