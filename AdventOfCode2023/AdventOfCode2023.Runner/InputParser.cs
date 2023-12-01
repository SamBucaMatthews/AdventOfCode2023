namespace AdventOfCode2023.Runner;

public static class InputParser
{
    public static IEnumerable<string> GetInput(string dayName)
    {
        var inputFile = $@".\Inputs\{dayName}\input.txt";

        return File.ReadAllLines(inputFile);
    }
}
