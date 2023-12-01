namespace AdventOfCode2023.Solutions;

public interface ISolve<out T>
{
    public T Solve(IEnumerable<string> inputs);
}
