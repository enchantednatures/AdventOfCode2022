namespace AdventOfCode.Day2;

public static class TournamentStrategyInputDeserializer
{
    public static Dictionary<int, Round> DeserializeLines(string[] input)
    {
        var result = new Dictionary<int, Round>();
        for (var i = 0; i < input.Length; i++)
        {
            var row = input[i].Split(" ");
            var opPlay = PlayReader.ReadInput(row[0]);
            var recPlay = StrategyReader.ReadInput(row[1]);

            result[i] = new Round(opPlay, recPlay);
        }

        return result;
    }
}