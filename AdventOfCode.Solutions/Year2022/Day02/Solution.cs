namespace AdventOfCode.Solutions.Year2022.Day02;

class Solution : SolutionBase
{
    public Solution() : base(02, 2022, "") { }

    protected override string SolvePartOne()
    {
        Dictionary<string, int> shapescores = new Dictionary<string, int>() { };
        shapescores["X"] = 1;
        shapescores["Y"] = 2;
        shapescores["Z"] = 3;
        shapescores["A"] = 1;
        shapescores["B"] = 2;
        shapescores["C"] = 3;
        var lines = Input.SplitByNewline();
        var totalscore = 0;
        foreach (var line in lines)
        {
            var roundscore = 0;
            var player = line.Split();
            roundscore += shapescores[player[1]];

            if (player[1] == "X")
            {
                if (player[0] == "A")
                    roundscore += 3;
                if (player[0] == "B")
                    roundscore += 0;
                if (player[0] == "C")
                    roundscore += 6;
            }
            if (player[1] == "Y")
            { //paper
                if (player[0] == "A")
                    roundscore += 6;
                if (player[0] == "B")
                    roundscore += 3;
                if (player[0] == "C")
                    roundscore += 0;
            }
            if (player[1] == "Z")
            { //scissors
                if (player[0] == "A")
                    roundscore += 0;
                if (player[0] == "B")
                    roundscore += 6;
                if (player[0] == "C")
                    roundscore += 3;
            }

            totalscore += roundscore;
        }

        return totalscore.ToString();
    }

    protected override string SolvePartTwo()
    {
        Dictionary<string, int> shapescores = new Dictionary<string, int>() { };
        shapescores["X"] = 1;
        shapescores["Y"] = 2;
        shapescores["Z"] = 3;
        shapescores["A"] = 1;
        shapescores["B"] = 2;
        shapescores["C"] = 3;
        var lines = Input.SplitByNewline();
        var totalscore = 0;
        foreach (var line in lines)
        {
            var roundscore = 0;
            var player = line.Split();

            var shape = "";
            if (player[1] == "X")
            {
                if (player[0] == "A")
                {
                    shape = "Z";
                    roundscore += 0;
                }
                if (player[0] == "B")
                {
                    shape = "X";
                    roundscore += 0;
                }
                if (player[0] == "C")
                {
                    shape = "Y";
                    roundscore += 0;
                }
            }
            if (player[1] == "Y")
            { //draw
                if (player[0] == "A") //rock
                {
                    shape = "X"; //rock
                    roundscore += 3;
                }
                if (player[0] == "B") //paper
                {
                    shape = "Y"; //paper
                    roundscore += 3;
                }
                if (player[0] == "C") //sci
                {
                    shape = "Z";//sci
                    roundscore += 3;
                }
            }
            if (player[1] == "Z") // win
            { //scissors
                if (player[0] == "A") //rock
                {
                    shape = "Y"; //paper
                    roundscore += 6;
                }
                if (player[0] == "B")//paper
                {
                    shape = "Z";//sci
                    roundscore += 6;
                }
                if (player[0] == "C")
                {
                    shape = "X";
                    roundscore += 6;
                }
            }

            roundscore += shapescores[shape];

            totalscore += roundscore;
        }

        return totalscore.ToString();
    }
}
