namespace AdventOfCode2023.Solutions.DayOne;

public class DayOne : ISolve<int>
{
    public int Solve(IEnumerable<string> inputs) =>
        inputs
            .Select(CalibrationValueParser.GetCalibrationValue)
            .Sum();
}