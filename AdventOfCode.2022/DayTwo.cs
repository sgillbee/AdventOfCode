namespace AdventOfCode2022;

public class DayTwo
{
    public static int FirstStar_TotalScoreForRockPaperScissors(string input)
    {
        var result = input.SplitToLines()
            .Select(ConvertXyzInputLineIntoAbcRoundLine)
            .Select(CalculateRoundScoreFromAbcRoundLine)
            .Sum();

        return result;
    }

    public static int SecondStar_ScoreForProjectedRockPaperScissorsMatch(string input)
    {
        var result = input.SplitToLines()
            .Select(ConvertXyzInputIntoAbcWinLossRoundLine)
            .Select(CalculateRoundScoreFromAbcRoundLine)
            .Sum();

        return result;
    }

    private static readonly Dictionary<string, int> RockPaperScissorsScores = new()
    {
        // Them/Me => game score (for me)
        { "A A", 3 },
        { "A B", 6 },
        { "A C", 0 },
        { "B A", 0 },
        { "B B", 3 },
        { "B C", 6 },
        { "C A", 6 },
        { "C B", 0 },
        { "C C", 3 },
    };

    private static readonly Dictionary<string, string> RockPaperScissorsRound = new()
    {
        // Them/Result => Them/Me
        { "A X", "A C" },
        { "A Y", "A A" },
        { "A Z", "A B" },
        { "B X", "B A" },
        { "B Y", "B B" },
        { "B Z", "B C" },
        { "C X", "C B" },
        { "C Y", "C C" },
        { "C Z", "C A" },
    };

    private static readonly Dictionary<string, int> RockPaperScissorsValues = new()
    {
        { "A", 1 },
        { "B", 2 },
        { "C", 3 }
    };

    private static string ConvertXyzInputIntoAbcWinLossRoundLine(string item)
    {
        return RockPaperScissorsRound[item];
    }

    private static string ConvertXyzInputLineIntoAbcRoundLine(string item)
    {
        return item.Replace("X", "A").Replace("Y", "B").Replace("Z", "C");
    }

    private static int CalculateRoundScoreFromAbcRoundLine(string item)
    {
        return RockPaperScissorsScores[item] + RockPaperScissorsValues[item.Substring(2)];
    }
}