namespace AdventOfCode;

public class MaxFinder
{
    public MaxFinder()
    {
        
    }

    public int GnomeWithMax(Dictionary<int, List<int>> input)
    {
        var maxCals = 0;
        var gnomesWithMaxCals = new List<int>(3);

        foreach ((int key, List<int> value) in input)
        {
            var cals = value.Sum();
            if (cals > maxCals)
            {
                maxCals = cals;
            }
        }

        var k = input
            .OrderByDescending(e => e.Value.Sum())
            .Take(3)
            .Sum(i => i.Value.Sum());
        
        return k;
    }
}