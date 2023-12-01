namespace AdventOfCode2023.Solutions.DayOne;

public static class CalibrationValueParser
{
    public static int GetCalibrationValue(string input)
    {
        var first = input.First(c => int.TryParse(c.ToString(), out _));
        var last = input.Last(c => int.TryParse(c.ToString(), out _));

        return int.Parse($"{first}{last}");
    }
}
