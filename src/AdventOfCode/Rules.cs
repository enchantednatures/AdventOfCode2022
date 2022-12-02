namespace AdventOfCode;

public static class Rules
{
    public static Plays? GetWinner(Plays elf, Plays op) =>
        (elf, op) switch
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