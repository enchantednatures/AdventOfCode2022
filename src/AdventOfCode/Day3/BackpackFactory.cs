namespace AdventOfCode.Day3;

public static class BackpackFactory
{
    public static IEnumerable<Backpack> Create(string[] data)
    {
        return data.Select(Create);
    }

    public static Backpack Create(string data)
    {
        List<BackpackItem> frontCompartment = new();
        List<BackpackItem> rearCompartment = new();
        for (var i = 0; i < data.Length / 2; i++)
        {
            frontCompartment.Add(new BackpackItem(data[i]));
            rearCompartment.Add(new BackpackItem(data[^(i + 1)]));
        }

        var backpack = new Backpack(frontCompartment, rearCompartment);
        return backpack;
    }
}