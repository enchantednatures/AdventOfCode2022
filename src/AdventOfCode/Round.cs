namespace AdventOfCode;

public readonly struct Round
{
    public Plays OpponentPlay { get; init; }
    public Plays RecommendedPlay { get; init; }

    public int PlayValue => (RecommendedPlay) switch
    {
        (Plays.Rock) => 1,
        (Plays.Paper) => 2,
        (Plays.Scissor) => 3,
        _ => 0
    };
    
    public Plays? Winner  =>
        (RecommendedPlay, OpponentPlay) switch
        {
            (Plays.Rock, Plays.Scissor) => Plays.Rock,
            (Plays.Scissor, Plays.Rock) => Plays.Rock,
            (Plays.Rock, Plays.Paper) => Plays.Paper,
            (Plays.Paper, Plays.Rock) => Plays.Paper,
            (Plays.Scissor, Plays.Paper) => Plays.Scissor,
            (Plays.Paper, Plays.Scissor) => Plays.Scissor,
            _ => null
        };

    public Round(Plays opponentPlay, Plays recommendedPlay)
    {
        OpponentPlay = opponentPlay;
        RecommendedPlay = recommendedPlay;
    }
}