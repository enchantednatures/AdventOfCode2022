namespace AdventOfCode.Day2;

public static class Rules
{
    public static Plays? GetWinner(Plays elf, Plays op)
    {
        return (elf, op) switch
        {
            (Plays.Rock, Plays.Scissor) => Plays.Rock,
            (Plays.Scissor, Plays.Rock) => Plays.Rock,
            (Plays.Rock, Plays.Paper) => Plays.Paper,
            (Plays.Paper, Plays.Rock) => Plays.Paper,
            (Plays.Scissor, Plays.Paper) => Plays.Scissor,
            (Plays.Paper, Plays.Scissor) => Plays.Scissor,
            _ => null
        };
    }
}