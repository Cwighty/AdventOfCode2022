namespace AdventOfCode.Solutions.Year2022.Day01;

class Solution : SolutionBase
{
    public Solution() : base(01, 2022, "") { }

    protected override string SolvePartOne()
    {
        var lines = Input.Split("\n");
        int max = 0;
        int sum = 0;
        foreach (var line in lines)
        {
            if (line == "")
            {
                if (sum > max)
                {
                    max = sum;
                }
                sum = 0;
            }
            else
            {
                sum += int.Parse(line);
            }

        }
        return max.ToString();
    }

    protected override string SolvePartTwo()
    {
        var lines = Input.Split("\n");
        List<int> sums = new();
        int sum = 0;
        foreach (var line in lines)
        {
            Console.WriteLine(line);
            if (line == "")
            {
                sums.Add(sum);
                sum = 0;
            }
            else
            {
                sum += int.Parse(line);
            }

        }
        var sorted = sums.OrderByDescending(s => s).ToArray();
        return (sorted[0] + sorted[1] + sorted[2]).ToString();
    }
}
