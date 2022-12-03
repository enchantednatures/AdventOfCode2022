namespace AdventOfCode.Day2;

public static class PlayReader
{
    public static Plays ReadInput(string input)
    {
        return input switch
        {
            "A" => Plays.Rock,
            "X" => Plays.Rock,
            "B" => Plays.Paper,
            "Y" => Plays.Paper,
            "C" => Plays.Scissor,
            "Z" => Plays.Scissor,
            _ => throw new Exception()
        };
    }
}