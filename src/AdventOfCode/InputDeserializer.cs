namespace AdventOfCode;

public class InputDeserializer
{
    public Dictionary<int, List<int>> DeserializeLines(string[] input)
    {
        var currentGnome = 1;
        var result = new Dictionary<int, List<int>>();
        result[currentGnome] = new List<int>();
        foreach (var row in input)
        {
            if (row == "")
            {
                currentGnome += 1;
                result[currentGnome] = new List<int>();
                continue;
            }

            int.TryParse(row, out var calories);
            result[currentGnome].Add(calories);
        }

        return result;
    }
}