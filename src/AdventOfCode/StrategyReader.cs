namespace AdventOfCode;

public static class StrategyReader
{
    public static Outcomes ReadInput(string input)
    {
        return input switch
        {
            "X" => Outcomes.Loss,
            "Y" => Outcomes.Draw,
            "Z" => Outcomes.Win,
            _ => throw new Exception()
        };
    }
}