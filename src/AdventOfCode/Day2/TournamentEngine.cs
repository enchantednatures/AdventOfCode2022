namespace AdventOfCode.Day2;

public class TournamentEngine
{
    private readonly Dictionary<int, Round> _data;

    public TournamentEngine(string[] input)
    {
        _data = TournamentStrategyInputDeserializer.DeserializeLines(input);
    }

    public int CalcScore()
    {
        var score = 0;
        for (var i = 0; i < _data.Keys.Count; i++)
        {
            var round = _data[i];
            score += round.RecommendedOutcome switch
            {
                Outcomes.Win => 6,
                Outcomes.Draw => 3,
                _ => 0
            };

            score += round.PlayValue;
        }

        return score;
    }
}