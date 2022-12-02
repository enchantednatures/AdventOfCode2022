namespace AdventOfCode;

public static class TournamentStrategyInputDeserializer
{
  
    public static Dictionary<int, Round> DeserializeLines(string[] input)
    {
        var result = new Dictionary<int,Round>();
        for (int i = 0; i < input.Length; i++)
        {
            var row = input[i].Split(" ");
            Plays opPlay = PlayReader.ReadInput(row[0]);
            Plays recPlay = PlayReader.ReadInput(row[1]);

            result[i] = new (opPlay, recPlay);
        }
        return result;
    }
}