namespace AdventOfCode.Day3;

public struct BackpackItem
{
    private readonly Dictionary<char, int> _priorities = BuildDict();
    public char Value { get; }
    public int Priority => _priorities[Value];

    public BackpackItem(char value)
    {
        Value = value;
    }

    private static Dictionary<char, int> BuildDict()
    {
        var characters = "abcdefghijklmnopqrstuvwxyz";
        characters += characters.ToUpper();
        var result = new Dictionary<char, int>();
        for (var i = 0; i < characters.Length; i++) result[characters[i]] = i + 1;

        return result;
    }
}