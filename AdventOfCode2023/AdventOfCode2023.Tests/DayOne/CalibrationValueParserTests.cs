namespace AdventOfCode2023.Tests.DayOne;

using AdventOfCode2023.Solutions.DayOne;

public class CalibrationValueParserTests
{
    [TestCase("1abc2", 12)]
    [TestCase("pqr3stu8vwx", 38)]
    [TestCase("a1b2c3d4e5f", 15)]
    [TestCase("treb7uchet", 77)]
    public void GetCalibrationValue_GivenInput_ReturnsFirstAndLastNumbers(string input, int expectedOutput)
    {
        var actualCalibrationValue = CalibrationValueParser.GetCalibrationValue(input);
        
        Assert.That(actualCalibrationValue, Is.EqualTo(expectedOutput));
    }
}
