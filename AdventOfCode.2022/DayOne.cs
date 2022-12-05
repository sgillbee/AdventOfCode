namespace AdventOfCode2022;

public class DayOne
{
    public static int FirstStar_GetLargestCalorieGroup(string input)
    {
        var result = CalculateTotalCalorieGroups(input).Max();
        return result;
    }

    public static int SecondStar_GetTotalOfThreeLargestCalorieGroups(string input)
    {
        var result = CalculateTotalCalorieGroups(input)
            .OrderByDescending(i => i)
            .Take(3)
            .Sum();
        return result;
    }

    private static IEnumerable<int> CalculateTotalCalorieGroups(string input)
    {
        return input.SplitToLines("\r\n\r\n")
            .Select(section => section.SplitToLines()
                .Select(int.Parse)
                .Sum());
    }
}