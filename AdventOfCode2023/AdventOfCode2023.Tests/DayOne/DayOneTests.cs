namespace AdventOfCode2023.Tests.DayOne;

using AdventOfCode2023.Solutions.DayOne;

public class DayOneTests
{
    [Test]
    public void Solve_GivenExampleInput_SolvesCorrectly()
    {
        var inputs = new[] {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet",
        };

        const int expected = 142;
        var solver = new DayOne();

        var actual = solver.Solve(inputs);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}
