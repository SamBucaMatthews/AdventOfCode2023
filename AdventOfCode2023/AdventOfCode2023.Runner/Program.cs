using AdventOfCode2023.Runner;
using AdventOfCode2023.Solutions.DayOne;

var dayOne = new DayOne();
var dayOneInput = InputParser.GetInput(nameof(DayOne));
var dayOneSolution = dayOne.Solve(dayOneInput);
Console.WriteLine(dayOneSolution);
