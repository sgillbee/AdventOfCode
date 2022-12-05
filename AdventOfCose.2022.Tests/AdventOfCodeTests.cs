using FluentAssertions;

namespace AdventOfCode2022.Tests;

public class AdventOfCodeTests
{
    [TestCase(typeof(DayOne), nameof(DayOne.FirstStar_GetLargestCalorieGroup), "Input_Day1.txt", 69693, TestName = "Day 1 / Star 1: Get Largest Calorie Group")]
    [TestCase(typeof(DayOne), nameof(DayOne.SecondStar_GetTotalOfThreeLargestCalorieGroups), "Input_Day1.txt", 200945, TestName = "Day 1 / Star 2: Get Total of 3 Largest Calorie Groups")]
    [TestCase(typeof(DayTwo), nameof(DayTwo.FirstStar_TotalScoreForRockPaperScissors), "Input_Day2.txt", 11150, TestName = "Day 2 / Star 1: Rock/Paper/Scissors Total Score")]
    [TestCase(typeof(DayTwo), nameof(DayTwo.SecondStar_ScoreForProjectedRockPaperScissorsMatch), "Input_Day2.txt", 8295, TestName = "Day 2 / Star 2: Rock/Paper/Scissors Score for Projected Round")]
    public void Test(
        Type targetType,
        string targetMethodName,
        string inputFile,
        int expectedResult)
    {
        // Arrange
        var input = AdventOfCodeInput.FetchInput(inputFile);
        var method = targetType.GetMethod(targetMethodName);

        // Act
        var result = (int)(method?.Invoke(null, new object[] { input }) ?? -1);

        // Assert
        result.Should().Be(expectedResult);
    }
}