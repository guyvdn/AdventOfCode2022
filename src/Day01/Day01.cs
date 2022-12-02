namespace AdventOfCode2020.Day01;

public class Day01
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly List<int> _totals;

    public Day01(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _totals = new List<int>();

        var currentCount = 0;

        foreach (var line in File.ReadLines(@"Day01\input.txt"))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                _totals.Add(currentCount);
                currentCount = 0;
                continue;
            }

            currentCount += int.Parse(line);
        }
    }

    [Fact]
    public void Puzzle1()
    {
        var top1 = _totals.MaxBy(x => x);
        _testOutputHelper.WriteLine(top1.ToString());
    }

    [Fact]
    public void Puzzle2()
    {
        var top3 = _totals.OrderByDescending(x => x).Take(3);
        _testOutputHelper.WriteLine(top3.Sum().ToString());
    }
}