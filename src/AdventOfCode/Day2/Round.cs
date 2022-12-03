namespace AdventOfCode.Day2;

public readonly struct Round
{
    public Plays OpponentPlay { get; init; }
    public Outcomes RecommendedOutcome { get; init; }

    public Plays MyPlay()
    {
        return (OpponentPlay, RecommendedOutcome) switch
        {
            (_, Outcomes.Draw) => OpponentPlay,
            (Plays.Scissor, Outcomes.Win) => Plays.Rock,
            (Plays.Paper, Outcomes.Win) => Plays.Scissor,
            (Plays.Rock, Outcomes.Win) => Plays.Paper,
            (Plays.Scissor, Outcomes.Loss) => Plays.Paper,
            (Plays.Paper, Outcomes.Loss) => Plays.Rock,
            (Plays.Rock, Outcomes.Loss) => Plays.Scissor,
            _ => throw new InvalidOperationException()
        };
    }

    public int PlayValue => MyPlay() switch
    {
        Plays.Rock => 1,
        Plays.Paper => 2,
        Plays.Scissor => 3,
        _ => 0
    };

    public Round(Plays opponentPlay, Outcomes recommendedOutcome)
    {
        OpponentPlay = opponentPlay;
        RecommendedOutcome = recommendedOutcome;
    }
}